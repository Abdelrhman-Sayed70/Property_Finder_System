using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PropertyFinder
{
    public partial class SignUpPage : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public SignUpPage()
        {   
            InitializeComponent();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void usertype_lbl_Click(object sender, EventArgs e)
        {

        }

        private void showpassword_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            password_txtBox.UseSystemPasswordChar = !showpassword_chkBox.Checked;
        }
        private bool checkValuesNotEmpty(string[] userInfo)
        {
            foreach (string textBoxValue in userInfo)
            {
                if (string.IsNullOrWhiteSpace(textBoxValue.Trim()))
                {
                    MessageBox.Show("One or more fields are empty. Fill all your data");
                    return false;
                }
            }
            return true;
        }

        private bool checkUnique()
        {
            string username = username_txtBox.Text;
            string useremail = email_txtBox.Text;
            string[] values = { username, useremail };
            string[] columns = { "user_name", "user_email" };

            for (int i = 0; i < values.Length; i++)
            {
                string value = values[i];
                string column = columns[i];
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM users WHERE " + column + " = :param";
                cmd.Parameters.Add("param", value);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(column + " is already used. Please choose another one!");
                    return false;
                }
            }
            return true;
        }

        private int getUserID()
        {
            int maxID, newID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getUserID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                newID = maxID + 1;
            }
            catch
            {
                newID = 1;
            }
            return newID;
        }
        

        private void signup_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            string username = username_txtBox.Text;
            string useremail = email_txtBox.Text;
            string usertype = "N";
            string password = password_txtBox.Text;
            string phonenumber = phonenumber_txtBox.Text;
            string[] userInfo = { username, useremail, password, phonenumber };
            bool ok = true;

            ok = checkValuesNotEmpty(userInfo);
            if (!ok) { return; }

            ok = traveller_btn.Checked || host_btn.Checked;
            if (!ok) { MessageBox.Show("Please specify your type!"); return; }
            
            if (traveller_btn.Checked) { usertype = "Traveller"; }
            else if (host_btn.Checked) { usertype = "Host"; }

            ok = checkUnique();
            if (!ok) { return; }

            int id = getUserID();
            
            cmd.CommandText = 
            @"
            insert into users
            values (:id, :username, :useremail, :usertype, :phone, :password, :balance)
            ";

            cmd.Parameters.Add("id", id);
            cmd.Parameters.Add("username", username);
            cmd.Parameters.Add("useremail", useremail);
            cmd.Parameters.Add("usertype", usertype);
            cmd.Parameters.Add("phone", phonenumber);
            cmd.Parameters.Add("password", password);
            cmd.Parameters.Add("balance", 2000);
     
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("One " + usertype + " added successfully");
            }

            // Swithc to login page
            this.Hide();
            LogInPage logInPage = new LogInPage();
            logInPage.ShowDialog();
            this.Close();
        }

        private void username_txtBox_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void username_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void password_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void email_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }



        private void phonenumber_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        
        private void signin_bnt_Click(object sender, EventArgs e)
        {
            // Swithc to login page
            this.Hide();
            LogInPage logInPage = new LogInPage();
            logInPage.ShowDialog();
            this.Close();
        }

        private void SignUpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}