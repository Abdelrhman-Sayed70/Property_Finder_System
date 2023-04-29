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
        string[] loc = { "Alexandria", "Assiut", "Aswan", "Beheira", "Bani Suef", "Cairo", "Daqahliya", "Damietta", "Fayyoum", "Gharbiya", "Giza", "Helwan", "Ismailia", "Kafr El Sheikh", "Luxor", "Marsa Matrouh", "Minya", "Monofiya", "New Valley", "North Sinai", "Port Said", "Qalioubiya", "Qena", "Red Sea", "Sharqiya", "Sohag", "South Sinai", "Suez", "Tanta" };
        public TravellerHomePage()
        {
            InitializeComponent();
        }
        private void TravellerHomePage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            currentUserId = getCurrentUser();
            if (currentUserId != -1)
            {
                fillComboBoxRooms();
                fillloc();
                fillGridOnload();
            }
            else
            {
                MessageBox.Show("Please Login First!");
                this.Hide();
                LogInPage logInPage = new LogInPage();
                logInPage.ShowDialog();
                this.Close();
            }
        }
        private void fillComboBoxRooms()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct no_rooms from Properties where current_status = 'y'";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rooms_cmboBox.Items.Add(dr[0]);
            }
            dr.Close();
            rooms_cmboBox.SelectedItem = "All";
        }
        private void fillloc()
        {
            int num = 0;
            while (num < loc.Length)
            {
                location_comboBox.Items.Add(loc[num]);
                num += 1;
            }
            location_comboBox.SelectedItem = "All";
        }
        private void fillGridOnload()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getPropsOnLoad";
            cmd.Parameters.Add("props", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            for (int i = 0; i < dr.FieldCount; i++)
            {
                DataColumn column = new DataColumn(dr.GetName(i));
                dataTable.Columns.Add(column);
            }
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    row[i] = dr.GetValue(i);
                }
                dataTable.Rows.Add(row);
            }
            Properties_datagrid.DataSource = dataTable;
            dr.Close();
        }
        private void completeprocess_btn_Click(object sender, EventArgs e)
        {

        }
        private int getCurrentUser()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getCurrentUser";
            cmd.Parameters.Add("currentId", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                return Convert.ToInt32(cmd.Parameters["currentId"].Value.ToString());
            }
            catch
            {
                return -1;
            }
        }
        private void balance_btn_Click(object sender, EventArgs e)
        {
            if (currentUserId != -1)
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
        }
        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (currentUserId != -1)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "logout";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Logged out Successfully!");
                this.Close();
            }
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (currentUserId != -1)
            {
                string pricestr = price_txtBox.Text.ToString();
                int price = 0;
                bool tst = int.TryParse(pricestr, out price);
                if (!tst && pricestr != "")
                    MessageBox.Show("Enter a number!");
                string priceCond = "";
                if (price > 0)
                    priceCond = " and property_cost <= " + price;

                string loc = location_comboBox.SelectedItem.ToString();
                string locCond = "";
                if (loc != "All")
                    locCond = " and property_location =" + "'" + loc + "'";

                String roomCond = "";
                int rooms = 0;
                if (rooms_cmboBox.SelectedItem.ToString() != "All")
                {
                    rooms = Convert.ToInt32(rooms_cmboBox.SelectedItem.ToString());
                    roomCond = " and no_rooms = " + "'" + rooms + "'";
                }

                string typeCond = "";
                if (Rent_chkBox.Checked && buy_chkBox.Checked)
                    typeCond = "and (market_status = 'rent' or market_status = 'buy')";
                else if (Rent_chkBox.Checked)
                    typeCond = "and market_status = 'rent'";
                else if (buy_chkBox.Checked)
                    typeCond = "and market_status = 'buy'";

                string nameCond = "";
                if (Villa_btn.Checked)
                    nameCond = "and property_name = 'Villa'";
                else if (land_btn.Checked)
                    nameCond = "and property_name = 'Land'";
                else if (House_btn.Checked)
                    nameCond = "and property_name = 'House'";
                else if (Appartement_btn.Checked)
                    nameCond = "and property_name = 'Appartment'";

                string serach = "select * from Properties where current_status = 'y' " + typeCond + roomCond + locCond + priceCond + nameCond;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = serach;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    DataColumn column = new DataColumn(dr.GetName(i));
                    dataTable.Columns.Add(column);
                }
                while (dr.Read())
                {
                    DataRow row = dataTable.NewRow();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        row[i] = dr.GetValue(i);
                    }
                    dataTable.Rows.Add(row);
                }
                Properties_datagrid.DataSource = dataTable;
                dr.Close();
            }
        }

        private void TravellerHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
