using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        CrystalReport2 cr;
        public Form2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
           
            foreach(ParameterDiscreteValue val in cr.Parameter_Case_Name.DefaultValues)
            {
                comboBox1.Items.Add(val.Value);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cr.SetParameterValue(0, comboBox1.Text);
            cr.SetParameterValue(1, textBox1.Text);
            cr.SetParameterValue(2, textBox2.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form4 = (Form4)Tag;
            form4.Show();
            Close();
        }
    }
}
