using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prisoner_ Crystal_prisoner = new Form1();
        }

        private void caseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Case prisoner_case = new Case();
            prisoner_case.Show();

            

            


        }

        private void disconnectedModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NavigationForm_Load(object sender, EventArgs e)
        {

        }

        private void prisonernameSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrisonerSearchWithName prisoner_search = new PrisonerSearchWithName();
            prisoner_search.Show();

        }

        private void prisonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prisoner prisoner = new Prisoner();
            prisoner.Show();

        }

        private void connectedModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visitFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitFunction visit_functions = new visitFunction();
            visit_functions.Show();
        }

        private void visitorFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitorFunction visitor_functions = new visitorFunction();
            visitor_functions.Show();
        }

        private void visitorSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitorSelection visitor_selection = new visitorSelection();
            visitor_selection.Show();
        }

        private void visitSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitSelection visit_selection = new visitSelection();
            visit_selection.Show();
        }
    }
}
