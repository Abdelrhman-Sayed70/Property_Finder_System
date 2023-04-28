using Oracle.DataAccess.Client;
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
using Oracle.DataAccess.Types;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PropertyFinder
{    
    public partial class HostHomePage : Form
    {
        string property_id, property_name, property_location, property_cost, market_status, current_status, no_rooms, user_id = "-1";
        string[] loc = { "Alexandria", "Assiut", "Aswan", "Beheira", "Bani Suef", "Cairo", "Daqahliya", "Damietta", "Fayyoum", "Gharbiya", "Giza", "Helwan", "Ismailia", "Kafr El Sheikh", "Luxor", "Marsa Matrouh", "Minya", "Monofiya", "New Valley", "North Sinai", "Port Said", "Qalioubiya", "Qena", "Red Sea", "Sharqiya", "Sohag", "South Sinai", "Suez", "Tanta" };
        private void House_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (House_btn.Checked == true)
            { property_name = "House";
                textBox1.Enabled = true;
            }
        }

        private void land_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (land_btn.Checked == true)
            {
                property_name = "Land";
                no_rooms = null;
                textBox1.Enabled=false;
            }
        }

        private void buy_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (buy_chkBox.Checked == true)
            {
                Rent_chkBox.Checked = false;
                market_status ="buy";
            }
        }

        private void Rent_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Rent_chkBox.Checked == true)
            {
                buy_chkBox.Checked = false;
                market_status = "Rent";

            }

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
        private void price_txtBox_TextChanged(object sender, EventArgs e)
        {
            property_cost = price_txtBox.Text;
            int number;
            bool tst = int.TryParse(property_cost, out number);
            if (!tst && property_cost!="")
                MessageBox.Show("Enter a number!");
        }

        private void location_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        

        private void HostHomePage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
            user_id = getCurrentUser().ToString();
        }

        private void Villa_btn_CheckedChanged(object sender, EventArgs e)
        { if (Villa_btn.Checked==true)
            property_name = "Villa";
            textBox1.Enabled = true;
        }

        string db = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public HostHomePage()
        {
           
            InitializeComponent();
            int num = 0;
            while (num < loc.Length)
            {
                location_comboBox.Items.Add(loc[num]);
                num += 1;
            }
            
        }

        private void addproperty_btn_Click(object sender, EventArgs e)
        {
            
            OracleCommand oracleCommand = new OracleCommand();
            OracleCommand oracleCommand2 = new OracleCommand();
            oracleCommand2.Connection = conn;
            oracleCommand.Connection = conn;
            oracleCommand2.CommandText = "SELECT count(*)FROM properties";
            OracleDataReader dr = oracleCommand2.ExecuteReader();

            if (dr.Read())
            {   
 
                property_id = dr[0].ToString();
                int id = int.Parse(property_id);
                id+=1;
                property_id = id.ToString();
            }
            current_status = "y";
            if (location_comboBox.SelectedIndex != -1)
            { property_location = location_comboBox.SelectedItem.ToString(); }
            else
            {
                property_location = "";
            }
                        //insert into properties values(8,      'land',   'cairo',             10,              'buy',          'y',         10,           1)
            oracleCommand.CommandText = "insert into properties values(:property_id,:property_name,:property_location,:property_cost,:market_status,:current_status,:no_rooms,:user_id)";
            oracleCommand.Parameters.Add("property_id",property_id);
            oracleCommand.Parameters.Add("property_name",     property_name);          
            oracleCommand.Parameters.Add("property_location", property_location);        
            oracleCommand.Parameters.Add("property_cost",     property_cost);
            oracleCommand.Parameters.Add("market_status",      market_status);
            oracleCommand.Parameters.Add("current_status",    current_status);
            oracleCommand.Parameters.Add("no_rooms",          no_rooms);
            oracleCommand.Parameters.Add("user_id", user_id);
            
            if (property_name != null &&property_location!=""&& property_cost != null && market_status != null && current_status != null&&(no_rooms!=null||(no_rooms==null&&property_name== "Land")) )
            {
                
                oracleCommand.ExecuteNonQuery();
                MessageBox.Show("property added successfully");
                Rent_chkBox.Checked = false;
                buy_chkBox.Checked = false;
                location_comboBox.SelectedIndex = -1;
                textBox1.Clear();
                price_txtBox.Clear();
                land_btn.Checked = false;
                Villa_btn.Checked = false;
                Appartement_btn.Checked = false;
                House_btn.Checked = false;
                location_comboBox.SelectedIndex = 0;
                textBox1.Enabled = true;
                property_id = null;
                property_name = null;
                property_location = null;
                property_cost = null;
                market_status = null;
                current_status = null;
                no_rooms = null;
                //user_id = null;

            }
            else
            {
                MessageBox.Show("Please Fill/Select Empty Fields");
            }
            

           
        }

        private void Appartement_btn_CheckedChanged(object sender, EventArgs e)
        {   if(Appartement_btn.Checked==true)
            property_name = "Appartement";
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            no_rooms = textBox1.Text;
            int number;
            bool tst = int.TryParse(no_rooms, out number);
            if (!tst && no_rooms != "")
                MessageBox.Show("Enter a number!");
            
        }
        private void my_prop_btn(object sender, EventArgs e)
        {
            this.Hide();
            HostProperties hostproprities = new HostProperties(user_id);
            hostproprities.ShowDialog();
            this.Close();
        }
        private void balance_btn_Click(object sender, EventArgs e)
        {
            if (user_id != "-1")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getBalance";
                cmd.Parameters.Add("userId", OracleDbType.Int32, ParameterDirection.Input).Value = user_id;
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
            if (user_id != "-1")
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
    }
}
