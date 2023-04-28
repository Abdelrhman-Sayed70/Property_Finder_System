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
        int price;

        public PaymentPage(int userID, int property_price)
        {
            //user_ID = userID;
            //price = property_price;
            user_ID = 1;
            price = 10000;
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
                cmd.Parameters.Add("id", user_ID);

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["USER_PASSWORD"].ToString() == user_password)
                    {
                        //check user balance
                        int user_balance = Convert.ToInt32(dr["USER_BALANCE"]);
                        if (user_balance >= price)
                        {
                            UpdateUserBalance(user_balance);
                        }
                        else
                        {
                            MessageBox.Show("Operation failed, there is not enough money...\nYour balance is: " + user_balance + "\nProperty Price is: " + price + "\nYou need " + (price - user_balance) + " to complete process");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
            }
            

        }

        private bool UpdateUserBalance(int user_balance)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE USERS SET USER_BALANCE = :balance WHERE USER_ID = :id";
            cmd.Parameters.Add(":balance", (user_balance - price));
            cmd.Parameters.Add(":id", user_ID);
            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Operation Completed Successfully!");
                return true;
            }
            MessageBox.Show("Failed!\nPlease try again...");
            return false;
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
