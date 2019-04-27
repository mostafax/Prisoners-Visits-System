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
    public partial class visitSelection : Form
    {
        string ordb = "data source = ORCL;user id = scott; password = tiger;";
        OracleConnection con;
        DataTable gridSource = new DataTable();
        public visitSelection()
        {
            InitializeComponent();
        }

        private void VisitSelection_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            gridSource.Columns.Add("Visit_ID", typeof(int));
            gridSource.Columns.Add("Day_Date", typeof(DateTime));
            gridSource.Columns.Add("START_TIME", typeof(float));
            gridSource.Columns.Add("END_TIME", typeof(float));
            gridSource.Columns.Add("Prisoner_ID", typeof(int));
            gridSource.Columns.Add("Visitor_ID", typeof(int));
            gridSource.Columns.Add("Prison_ID", typeof(int));
            gridSource.Columns.Add("Policeman_ID", typeof(int));

            visit_data_gridView.DataSource = gridSource;

            cmd.CommandText = "select v_id from visit";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                VisitIDS.Items.Add(reader[0].ToString());
                VisitIDS.SelectedIndex = 0;
            }

            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "getAllData";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("data",OracleDbType.RefCursor,ParameterDirection.Output);

            reader = c.ExecuteReader();
            while (reader.Read())
            {
                gridSource.Rows.Add(reader[0].ToString(), reader[1].ToString(), String.Format("{0:0000}", reader[2])
                    ,reader[3].ToString(), reader[4].ToString(),reader[5].ToString(),reader[6].ToString()
                    ,reader[7].ToString());
            }


        }

        private void VisitIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            DateTime date;
            c.Connection = con;
            c.CommandText = "getDate";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id", Convert.ToInt32(VisitIDS.SelectedItem.ToString()));
            c.Parameters.Add("DAY_DATE", OracleDbType.Date, ParameterDirection.Output);

            c.ExecuteNonQuery();
            date = Convert.ToDateTime(c.Parameters["DAY_DATE"].Value.ToString());
            string date_string = date.ToString();
            string str = date_string.Substring(0, 10);
            visit_name.Text = str;

        }
    }
}
