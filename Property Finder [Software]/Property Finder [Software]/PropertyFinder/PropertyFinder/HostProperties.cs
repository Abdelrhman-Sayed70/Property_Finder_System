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
    public partial class HostProperties : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds = new DataSet();
        string id;
        string cmdstr;
        string constr;
        string filter;

        public HostProperties(string id)
        {   
            InitializeComponent();
            this.id = id;
        }

        private void HostProperties_Load(object sender, EventArgs e)
        {
            constr = "Data source=orcl;User Id=scott; Password=tiger;";
            cmdstr = "select * from Properties where user_id = :id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", id);
            adapter.Fill(ds);
            hostproperties_dataGrid.DataSource = ds.Tables[0];


        }

        private void hostproperties_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Changes Saved Successfully!");
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HostHomePage hosthomepage = new HostHomePage();
            hosthomepage.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rent_radioButton_CheckedChanged(object sender, EventArgs e)
        {

            ds.Clear();
            cmdstr = "select * from Properties where user_id = :id and MARKET_STATUS = :filter";
            filter = "Rent";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", id);
            adapter.SelectCommand.Parameters.Add("filter", filter);
            adapter.Fill(ds);
            hostproperties_dataGrid.DataSource = ds.Tables[0];
        }

        private void buy_redioButton_CheckedChanged(object sender, EventArgs e)
        {
            ds.Clear();
            cmdstr = "select * from Properties where user_id = :id and MARKET_STATUS = :filter";
            filter = "Buy";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", id);
            adapter.SelectCommand.Parameters.Add("filter", filter);
            adapter.Fill(ds);
            hostproperties_dataGrid.DataSource = ds.Tables[0];
        }
    }
}
