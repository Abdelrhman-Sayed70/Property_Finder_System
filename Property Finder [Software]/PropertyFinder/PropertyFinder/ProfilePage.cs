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

namespace PropertyFinder
{
    public partial class ProfilePage : Form
    {
        int userID;
        string username;
        string userPassword;
        string userEmail;
        string userPhone;
        string userBalance;
        string userType;

        string ordb = "Data Source = orcl; User Id = scott; Password = tiger;";
        OracleConnection conn;

        public ProfilePage(int id)
        {
            userID = id;
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            GetUserData(userID);
        }

        private void GetUserData(int userID)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM USERS WHERE USER_ID = :id";
            cmd.Parameters.Add("id", userID);
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox_username.Text = dr["USER_NAME"].ToString();
                textBox_password.Text = dr["USER_PASSWORD"].ToString();
                textBox_email.Text = dr["USER_EMAIL"].ToString();
                textBox_phone.Text = dr["USER_PHONE_NUMBER"].ToString();
                textBox_balance.Text = dr["USER_BALANCE"].ToString();
                textBox_userType.Text = dr["USER_TYPE"].ToString();
            }
            dr.Close();

        }

        private void button_edit_data_Click(object sender, EventArgs e)
        {
            textBox_password.Enabled = true;
            textBox_email.Enabled = true;
            textBox_phone.Enabled = true;
            textBox_balance.Enabled = true;
        }

        private void ProfilePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void saveChanges_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE USERS SET USER_PASSWORD = :password, USER_EMAIL = :email, USER_PHONE_NUMBER = :phone, USER_BALANCE = :balance WHERE USER_ID = :id";

            cmd.Parameters.Add("password", textBox_password.Text);
            cmd.Parameters.Add("email", textBox_email.Text);
            cmd.Parameters.Add("phone", textBox_phone.Text);
            cmd.Parameters.Add("balance", textBox_balance.Text); 
            cmd.Parameters.Add("id", userID);

            cmd.CommandType = CommandType.Text;

            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Edited Successfully!");
            }
            else
            {
                MessageBox.Show("Error!\nTry again...");
            }

        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (userID != -1)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "logout";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Logged out Successfully!");
                this.Close();
            }
            this.Hide();
            LogInPage logInPage = new LogInPage();
            logInPage.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(userType == "Traveller")
            {
                this.Hide();
                TravellerHomePage travellerHomePage = new TravellerHomePage();
                travellerHomePage.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                HostHomePage hostHomePage = new HostHomePage();
                hostHomePage.ShowDialog();
                this.Close();
            }
        }
    }
}
