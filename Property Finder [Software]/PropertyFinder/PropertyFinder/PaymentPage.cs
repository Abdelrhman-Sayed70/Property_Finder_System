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
using System.Text.RegularExpressions;

namespace PropertyFinder
{
    public partial class PaymentPage : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int user_ID;

        public PaymentPage(int userID)
        {
            user_ID = userID;
            InitializeComponent();
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            string credit_card_id = creditcard_txtBox.Text;
            string user_password = password_txtBox.Text;
            if(Validate_Inputs(credit_card_id, user_password))
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM USERS WHERE USER_ID = :id";
                cmd.Parameters.Add("id", 1);
                //cmd.Parameters.Add("id", user_ID);

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["USER_PASSWORD"].ToString() == user_password)
                    {
                        MessageBox.Show("Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
            }
            

        }
        private bool Validate_Inputs(string credit_card_id, string password)
        {
            Regex credit_card_id_regex = new Regex(@"^[0-9]");

            if (string.IsNullOrEmpty(credit_card_id) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Fill Empty Fields!");
                return false;
            }
            if (!credit_card_id_regex.IsMatch(credit_card_id))
            {
                MessageBox.Show("Invalid Credit Card ID");
                return false;
            }
            return true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TravellerHomePage travellerHomePage = new TravellerHomePage();
            travellerHomePage.ShowDialog();
            this.Close();
        }
    }
}
