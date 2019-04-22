using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace DB
{
    public partial class Case : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string con = "data source = ORCL;user id = scott; password = tiger;";
        public Case()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Case_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OracleDataAdapter adapter1 = new OracleDataAdapter("SELECT * from case", con);
            adapter1.Fill(ds,"case");

            OracleDataAdapter adapter2 = new OracleDataAdapter("SELECT * from prisoner", con);
            adapter2.Fill(ds,"prisoners");
            
            DataRelation r = new DataRelation("fk",ds.Tables[0].Columns["case_id"],
                                                ds.Tables[1].Columns["pr_id"] );
            ds.Relations.Add(r);

            BindingSource bs_Master = new BindingSource(ds, "case");
            BindingSource bs_Child = new BindingSource(bs_Master, "fk");

            dataGridView1.DataSource = bs_Master;
            dataGridView2.DataSource = bs_Child;
        }
    }
}
