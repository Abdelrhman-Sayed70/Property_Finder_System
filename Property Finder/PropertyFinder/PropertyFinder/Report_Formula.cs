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
    public partial class Report_Formula : Form
    {
        CrystalReport_Formula CR;
        public Report_Formula()
        {
            InitializeComponent();
        }



        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.ShowDialog();
            this.Close();
        }

        private void Report_Formula_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport_Formula();
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
