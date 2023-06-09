﻿using System;
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
    public partial class Report_Summary : Form
    {
        SummaryReport CR;
        public Report_Summary()
        {
            InitializeComponent();
        }

        private void Report_Summary_Load(object sender, EventArgs e)
        {
            CR = new SummaryReport();
            crystalReportViewer1.ReportSource = CR;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.ShowDialog();
            this.Close();
        }
    }
}
