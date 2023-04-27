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
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void create_account_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {

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

        private void login_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
