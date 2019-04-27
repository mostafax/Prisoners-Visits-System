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
        OracleConnection conn;
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

            string cmdstr = @"insert into case 
                values (:case_ids , :case_names) 
                                                    ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("case_ids", textBox2.Text);
            adapter.SelectCommand.Parameters.Add("case_names", comboBox2.Text);


            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
            
        private void Case_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OracleDataAdapter adapter1 = new OracleDataAdapter("SELECT * from prison", con);
            adapter1.Fill(ds, "prison");

            OracleDataAdapter adapter2 = new OracleDataAdapter("SELECT * from prisoner", con);
            adapter2.Fill(ds, "prisoner");

            DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["prison_id"],
                                                ds.Tables[1].Columns["prison_id"]);
            ds.Relations.Add(r);

            BindingSource bs_Master = new BindingSource(ds, "prison");
            BindingSource bs_Child = new BindingSource(bs_Master, "fk");

            dataGridView1.DataSource = bs_Master;
            dataGridView2.DataSource = bs_Child;


            conn = new OracleConnection(con);

            OracleCommand cmd = new OracleCommand();

            conn.Open();
            cmd.CommandText = "select case_name from case";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0].ToString());
                comboBox2.SelectedIndex = 0;
            }
            reader.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from case where case_name=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.Add("name", comboBox2.SelectedItem.ToString());
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader[0].ToString();
            }

            reader.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdstr = "Delete from case where case_name = :case_name ";

            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("case_name", comboBox2.Text);

            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdstr = @"update case
                              set case_id = :id , case_name = :name where case_id = :id ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("id", textBox2.Text);
            adapter.SelectCommand.Parameters.Add("name", comboBox2.Text);

            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
