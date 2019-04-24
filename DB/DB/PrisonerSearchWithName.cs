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
    public partial class PrisonerSearchWithName : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        string con = "data source = ORCL;user id = scott; password = tiger;";

        public PrisonerSearchWithName()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from prisoner where pr_name like :name|| '%' ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", comboBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void PrisonerSearchWithName_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(con);

            OracleCommand cmd = new OracleCommand();

            conn.Open();
            cmd.CommandText = "select pr_name from prisoner";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
                comboBox1.SelectedIndex = 0;
            }
            reader.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
