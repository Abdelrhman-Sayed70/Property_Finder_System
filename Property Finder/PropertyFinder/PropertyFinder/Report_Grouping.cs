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
    public partial class Report_Grouping : Form
    {
        GroupingReportrpt CR;
        public Report_Grouping()
        {
            InitializeComponent();
        }

        private void Report_Grouping_Load(object sender, EventArgs e)
        {
            CR = new GroupingReportrpt();
            crystalReportViewer1.ReportSource = CR;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.ShowDialog();
            this.Close();
        }
    }
}
