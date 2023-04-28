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
        public HostProperties(string id)
        {   
            InitializeComponent();
            this.id = id;
        }

        private void HostProperties_Load(object sender, EventArgs e)
        {
            string constr = "Data source=orcl;User Id=scott; Password=tiger;";
            string cmdstr = "select * from Properties where user_id = :id";
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
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HostHomePage hosthomepage = new HostHomePage();
            hosthomepage.ShowDialog();
            this.Close();
        }
    }
}
