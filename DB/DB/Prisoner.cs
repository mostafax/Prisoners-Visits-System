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
    public partial class Prisoner : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string con = "Data Source = orcl; User Id = scott; Password = tiger;";

        public Prisoner()
        {
            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Prisoner_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void insert_Click(object sender, EventArgs e)
        {

            string cmdstr = @"insert into prisoner 
                values (:name , :age , :time , :start_date , :id , :gender) 
                                                    ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", Name_cm.Text);
            adapter.SelectCommand.Parameters.Add("age", Age_txt.Text);
            adapter.SelectCommand.Parameters.Add("time", duration_txt.Text );
            adapter.SelectCommand.Parameters.Add("start_date", dateTimePicker1.Text);
            adapter.SelectCommand.Parameters.Add("id", id_txt.Text);
            adapter.SelectCommand.Parameters.Add("gender", gender_txt.Text);
            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void Selectall_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from prison";
            adapter = new OracleDataAdapter(cmdstr, con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void update_Click(object sender, EventArgs e)
        {
            string cmdstr = @"update prisoner set pr_name = :name , pr_age = :age , pr_time = :time , pr_time_satrt = :start_date  , pr_id = :id , pr_gender = :gender ; ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", Name_cm.Text);
            adapter.SelectCommand.Parameters.Add("age", Age_txt.Text);
            adapter.SelectCommand.Parameters.Add("time", duration_txt.Text);
            adapter.SelectCommand.Parameters.Add("start_date", dateTimePicker1.Text);
            adapter.SelectCommand.Parameters.Add("id", id_txt.Text);
            adapter.SelectCommand.Parameters.Add("gender", gender_txt.Text);
            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string cmdstr = "Delete from prisoner where pr_name = :name ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", Name_cm.Text);
            ds = new DataSet();
            adapter.Fill(ds);

        }
    }
}
