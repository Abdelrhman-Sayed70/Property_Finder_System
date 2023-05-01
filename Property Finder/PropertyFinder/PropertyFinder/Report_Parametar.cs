using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace PropertyFinder
{
    public partial class Report_Parametar : Form
    {
        CrystalReport_Parametar CR;
        public Report_Parametar()
        {
            InitializeComponent();
        }

        private void Report_Parametar_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport_Parametar();

            foreach(ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.ShowDialog();
            this.Close();
        }

        private void button_generate_report_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please choose filter first!");
            }
            else
            {
                CR.SetParameterValue(0, comboBox1.Text);
                crystalReportViewer1.ReportSource = CR;
            }
            
        }
    }
}
