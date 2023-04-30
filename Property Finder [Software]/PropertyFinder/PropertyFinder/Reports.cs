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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button_report_grouping_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_Grouping report_Grouping = new Report_Grouping();
            report_Grouping.ShowDialog();
            this.Close();
        }

        private void button_report_summary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_Summary report_Summary = new Report_Summary();
            report_Summary.ShowDialog();
            this.Close();
        }

        private void button_report_formula_Click(object sender, EventArgs e)
        {

        }

        private void button_report_parametar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_Parametar report_Parametar = new Report_Parametar();
            report_Parametar.ShowDialog();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HostHomePage hosthomepage = new HostHomePage();
            hosthomepage.ShowDialog();
            this.Close();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
