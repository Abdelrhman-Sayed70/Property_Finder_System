using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PropertyFinder
{
    public partial class TravellerHomePage : Form
    {
        int currentUserId = -1;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public TravellerHomePage()
        {
            InitializeComponent();
        }

        private void TravellerHomePage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            getCurrentUser();
            fillComboBoxes();
            fillGridOnload();
        }
        private void fillComboBoxes()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string[] cols = { "property_location", "no_rooms" };
            foreach (var col in cols)
            {
                cmd.CommandText = "select distinct :col from Properties where current_status = 'Y'";
                cmd.Parameters.Add("col", col);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (col == "property_location")
                        location_comboBox.Items.Add(dr[0]);
                    else
                        rooms_cmboBox.Items.Add(dr[0]);
                }
                dr.Close();
            }
            location_comboBox.SelectedItem = "All";
            rooms_cmboBox.SelectedItem = "All";
        }
        private void fillGridOnload()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getPropsOnLoad";
            cmd.Parameters.Add("props", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // check it
                Properties_datagrid.Rows.Add(dr);
            }
            dr.Close();
        }
        private void completeprocess_btn_Click(object sender, EventArgs e)
        {

        }
        private void getCurrentUser()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getCurrentUser";
            cmd.Parameters.Add("currentId", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                currentUserId = Convert.ToInt32(cmd.Parameters["currentId"].Value);
            }
            catch
            {
                MessageBox.Show("Please Login First!");
            }
        }
        private void balance_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getBalance";
            cmd.Parameters.Add("userId", OracleDbType.Int32, ParameterDirection.Input).Value = currentUserId;
            cmd.Parameters.Add("userbalance", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                string balancemsg = "Your balance is: " + cmd.Parameters["userbalance"].Value.ToString();
                MessageBox.Show(balancemsg);
            }
            catch
            {
                MessageBox.Show("Please Login First!");
            }
        }
        private void logout_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "logout";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Logged out Successfully!");
            this.Hide();
            LogInPage logInPage = new LogInPage();
            logInPage.ShowDialog();
            this.Close();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(price_txtBox.Text.ToString());
            string priceCond = "";
            if (price > 0)
                priceCond = " and property_cost <= " + price;

            string loc = location_comboBox.SelectedItem.ToString();
            string locCond = "";
            if (loc != "All")
                locCond = " and property_location =" + loc;

            String roomCond = "";
            int rooms = 0;
            if (rooms_cmboBox.SelectedItem.ToString() != "All")
            {
                rooms = Convert.ToInt32(rooms_cmboBox.SelectedItem.ToString());
                roomCond = " and no_rooms = " + rooms;
            }

            string typeCond = "";
            if (Rent_chkBox.Checked && buy_chkBox.Checked)
                typeCond = "and (market_status = rent or market_status = buy)";
            else if (Rent_chkBox.Checked)
                typeCond = "and market_status = rent";
            else if (buy_chkBox.Checked)
                typeCond = "and market_status = buy";

            string nameCond = "";
            if (Villa_btn.Checked)
                nameCond = "and property_name = Villa";
            else if (land_btn.Checked)
                nameCond = "and property_name = Land";
            else if (House_btn.Checked)
                nameCond = "and property_name = House";
            else if (Appartement_btn.Checked)
                nameCond = "and property_name = Appartment";

            Properties_datagrid.Rows.Clear();
            string serach = "select * from Properties where current_status = 'Y' " + typeCond + roomCond + locCond + priceCond + nameCond;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = serach;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // check it
                Properties_datagrid.Rows.Add(dr);
            }
            dr.Close();
        }
    }
}
