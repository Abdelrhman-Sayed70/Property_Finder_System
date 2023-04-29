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

namespace PropertyFinder
{
    public partial class LogInPage : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        int userId;

        public LogInPage()
        {
            InitializeComponent();
        }

        private int GetCurrentUser()
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

        private void LogInPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            int userid = GetCurrentUser();
            if (userid != -1)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                @"
                select *
                from users
                where user_id = :id
                ";
                cmd.Parameters.Add("id", userid.ToString());
                OracleDataReader dr = cmd.ExecuteReader();
                string username = "Huh";
                if (dr.Read())
                    username = dr["user_name"].ToString();

                MessageBox.Show("Authentication Created Successfully. Welcome " + username);
                GoToUserHomePage(userid);
            }
        }

        private void showpassword_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!showpassword_chkBox.Checked)
            {
                password_txtBox.PasswordChar = '•';
            }
            else
            {
                password_txtBox.PasswordChar = '\0';
            }
        }

        private void password_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            // Swithc to signup page
            this.Hide();
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.ShowDialog();
            this.Close();
        }

        private void LogInPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Get the user inputs: Name & Password
            string username = username_txtBox.Text;
            string password = password_txtBox.Text;

            // Validate inputs
            if (Validate_Inputs(username, password))
            {
                // Check if the user exists in the "users" table
                if (User_Exists(username, password))
                {
                    // Add user to current user table
                    if (AddUserToCurrentUserTable(userId))
                    {
                        // Go to home page pased on his role if he is:
                        // Traveller -> go to Traveller home page
                        // Host -> go to Host home page

                        GoToUserHomePage(userId);
                    }

                }
            }
        }

        private void GoToUserHomePage(int userId)
        {
            // Determine the appropriate home page URL based on the user's ID
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT USER_TYPE FROM USERS WHERE USER_ID = :id";
            cmd.Parameters.Add("id", userId);

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string role = dr[0].ToString();

                // Determine the appropriate URL based on the user's role
                if (role == "Traveller")
                {
                    //MessageBox.Show("Traveller");
                    this.Hide();
                    TravellerHomePage travelerHomePage = new TravellerHomePage();
                    travelerHomePage.ShowDialog();
                    this.Close();
                }
                else if (role == "Host")
                {
                    // MessageBox.Show("Host");

                    this.Hide();
                    HostHomePage hostHomePage = new HostHomePage();
                    hostHomePage.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid role please try again");
                }
            }
        }

        private bool AddUserToCurrentUserTable(int userId)
        {
            clear_current_user();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            //Don't forget to check if user already logged in or not because it threw exception
            // Create a new record in the current user table for the specified user
            cmd.CommandText = "INSERT INTO CURRENT_USERS VALUES (:id)";
            cmd.Parameters.Add("id", userId);
            int r = cmd.ExecuteNonQuery();
            if (r == -1)
            {
                MessageBox.Show("Error!!\nPlease try again...");
                return false;
            }
            return true;
        }

        private bool User_Exists(string username, string password)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM USERS WHERE USER_NAME = :username";
            cmd.Parameters.Add("username", username);

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["USER_PASSWORD"].ToString() == password)
                {
                    userId = Convert.ToInt32(dr["USER_ID"]);
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    return false;
                }
            }
            MessageBox.Show("Invalid Username or Password");
            return false;
        }

        private bool Validate_Inputs(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Fill Empty Fields!");
                return false;
            }
            return true;
        }
        private void clear_current_user()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from current_users";
            int res = cmd.ExecuteNonQuery();
        }

        private void username_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}