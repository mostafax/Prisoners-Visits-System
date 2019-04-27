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
    public partial class visitFunction : Form
    {   //Useless.    
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // ========================================================================================

        string ordb = "Data source =ORCL; User Id = scott; password = tiger;";
        OracleConnection con;

        public visitFunction()
        {
            InitializeComponent();
        }



       
        private void visitFunction_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select v_id from visit";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                visitIDS.Items.Add(reader[0].ToString());
                visitIDS.SelectedIndex = 0;
            }
            // Adding Visitor IDS
            cmd.CommandText = "select visitor_id from visitor";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                visitor_ids.Items.Add(reader[0].ToString());
            }
            // Adding Policemen IDS
            cmd.CommandText = "select po_id from policeman";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                policemen_ids.Items.Add(reader[0].ToString());
            }
            // Adding Prisoner IDS
            cmd.CommandText = "select pr_id from prisoner";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                prisoner_ids.Items.Add(reader[0].ToString());
            }

            // Adding Prison IDS
            cmd.CommandText = "select prison_ID from prison";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                prison_ids.Items.Add(reader[0].ToString());
            }
        }

        private void visitIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Setting the data.
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from visit where v_id =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", visitIDS.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                string day_date;
                day_date = dr[1].ToString();
                string str = day_date.Substring(0, 9);
                visit_day_date.Text = str;
                visit_start_time.Text = dr[2].ToString();
                visit_end_time.Text = dr[3].ToString();
                prisoner_id.Text = dr[4].ToString();
                visitor_id.Text = dr[5].ToString();
                prison_id.Text = dr[6].ToString();
                policeman_id.Text = dr[7].ToString();
            }
            dr.Close();
        }

        private void add_visit_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "insertVisit";
            c.Parameters.Add("VID", visitIDS.Text);
            c.Parameters.Add("day", Convert.ToDateTime(visit_day_date.Text));
            c.Parameters.Add("start", visit_start_time.Text);
            c.Parameters.Add("end", visit_end_time.Text);
            c.Parameters.Add("prID", prisoner_id.Text);
            c.Parameters.Add("viID", visitor_id.Text);
            c.Parameters.Add("prID", prison_id.Text);
            c.Parameters.Add("poID", policeman_id.Text);

            c.ExecuteNonQuery();
            MessageBox.Show("Visit entered successfully");
            visitIDS.Items.Add(visitIDS.Text);

        }

        private void delete_visit_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteVisit";
            cmd.Parameters.Add("id", visitIDS.Text); // BIND VALUE;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Visit is Deleted");
            visitIDS.Items.RemoveAt(visitIDS.SelectedIndex);
            visit_day_date.Text = "";
            visit_start_time.Text = "";
            visit_end_time.Text = "";
            prisoner_id.Text = "";
            visitor_id.Text = "";
            prison_id.Text = "";
            policeman_id.Text = "";
        }

        private void update_visit_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateVisit";
            cmd.Parameters.Add("day", Convert.ToDateTime(visit_day_date.Text));
            cmd.Parameters.Add("start", visit_start_time.Text);
            cmd.Parameters.Add("end", visit_end_time.Text);
            cmd.Parameters.Add("prisoner_ID", prisoner_id.Text);
            cmd.Parameters.Add("vi_ID", visitor_id.Text);
            cmd.Parameters.Add("pris_ID", prison_id.Text);
            cmd.Parameters.Add("policeman_ID", policeman_id.Text);
            cmd.Parameters.Add("V_ID", Convert.ToInt32(visitIDS.SelectedIndex.ToString())+1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Visit is Updated");
            
        }
    }
}
