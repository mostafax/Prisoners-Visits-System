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

namespace WindowsFormsApp1
{
    public partial class Prisoner : Form
    {   
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string con = "data source = ORCL;user id = scott; password = tiger;";
        OracleConnection conn;
        string Prison_ID;

        public Prisoner()
        {
            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Prisoner_Load(object sender, EventArgs e)
        {
           conn = new OracleConnection(con);
        
            OracleCommand cmd = new OracleCommand();

            conn.Open();
            cmd.CommandText = "select pr_name from prisoner";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name_cm.Items.Add(reader[0].ToString());
                Name_cm.SelectedIndex = 0;
            }
            reader.Close();


            conn = new OracleConnection(con);

             cmd = new OracleCommand();

            conn.Open();
            cmd.CommandText = "select prison_name from prison";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
             reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
                comboBox1.SelectedIndex = 0;
            }
            reader.Close();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void insert_Click(object sender, EventArgs e)
        {

            string cmdstr = @"insert into prisoner 
                values (:name , :age , :time , :start_date , :id , :gender,:prison_id,:cell) 
                                                    ";

            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", Name_cm.Text);
            adapter.SelectCommand.Parameters.Add("age", Age_txt.Text);
            adapter.SelectCommand.Parameters.Add("time", duration_txt.Text );
            adapter.SelectCommand.Parameters.Add("start_date", Convert.ToDateTime(dateTimePicker1.Text));
            adapter.SelectCommand.Parameters.Add("id", id_txt.Text);
            adapter.SelectCommand.Parameters.Add("gender", gender_txt.Text);
            adapter.SelectCommand.Parameters.Add("prison_id", Prison_ID);
            adapter.SelectCommand.Parameters.Add("cell", cell_txt.Text);

            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void Selectall_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from prisoner";
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
            string cmdstr = @"update prisoner
                              set pr_name = :name, pr_age = :age , pr_time = :time , pr_start_time = :start_date , pr_gender = :gender , prison_id = :prison , cell_number= :cell  
                              where pr_id = :id ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", (string)Name_cm.Text);
            adapter.SelectCommand.Parameters.Add("age", Age_txt.Text);
            adapter.SelectCommand.Parameters.Add("time", duration_txt.Text);
            adapter.SelectCommand.Parameters.Add("start_date", Convert.ToDateTime(dateTimePicker1.Text));
            adapter.SelectCommand.Parameters.Add("gender", gender_txt.Text);
            adapter.SelectCommand.Parameters.Add("prison", Prison_ID);
            adapter.SelectCommand.Parameters.Add("cell", cell_txt.Text);

            adapter.SelectCommand.Parameters.Add("id", id_txt.Text);
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

        private void Name_cm_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from prisoner where pr_name=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.Add("name", Name_cm.SelectedItem.ToString());
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Age_txt.Text = reader[1].ToString();
                duration_txt.Text = reader[2].ToString();
                //dateTimePicker1.Text = reader[3].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(reader[3]);
                gender_txt.Text = reader[5].ToString();
                id_txt.Text = reader[4].ToString();
                cell_txt.Text= reader[7].ToString();
                Prison_ID = reader[6].ToString();
            }

            textBox1.Text = dateTimePicker1.Value.AddMonths(int.Parse(duration_txt.Text)).ToString();
            reader.Close();

            

             cmd = new OracleCommand();
            cmd.CommandText = "select prison_name from prison where prison_id =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.Add("id", Prison_ID);
             reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                comboBox1.Text = reader[0].ToString();
  
            }

            reader.Close();

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from prison where prison_name=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.Add("name", comboBox1.SelectedItem.ToString());
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Prison_ID = reader[0].ToString();
            }
            reader.Close();

        }
    }
    }
