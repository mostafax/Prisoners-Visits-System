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
    public partial class visitorSelection : Form
    {
        string ordb = "Data source =ORCL; User Id = scott; password = tiger;";
        OracleConnection con;
        DataTable gridSource = new DataTable();

        public visitorSelection()
        {
            InitializeComponent();

        }

        private void visitorSelection_Load(object sender, EventArgs e)
        { 
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            gridSource.Columns.Add("ID", typeof(int));
            gridSource.Columns.Add("Visitor Name", typeof(string));
            gridSource.Columns.Add("Prisoner Name", typeof(string));
            select_all_visitors.DataSource = gridSource;

            ///////////// USING WHERE CONDITION
            cmd.Connection = con;
            cmd.CommandText = "select visitor_Name from visitor where visitor_id = 1";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                visitor_name.Text = reader[0].ToString();
            }

            ///////////// NOT USING WHERE CONDITION.
            cmd.Connection = con;
            cmd.CommandText = "select * from visitor";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                gridSource.Rows.Add(reader[0].ToString(),reader[2].ToString(), reader[1].ToString());
            }
        }

        private void visitorSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
