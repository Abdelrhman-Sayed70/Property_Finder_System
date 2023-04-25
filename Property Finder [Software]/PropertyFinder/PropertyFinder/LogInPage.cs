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
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }

        private void create_account_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {

        }

        private void showpassword_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword_chkBox.Checked)
            {
                password_txtBox.PasswordChar = '\0';
            }
            else
            {
                password_txtBox.PasswordChar = '•';
            }
        }

        private void password_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
