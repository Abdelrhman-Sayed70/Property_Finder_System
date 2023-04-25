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
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }

        private void usertype_lbl_Click(object sender, EventArgs e)
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
    }
}
