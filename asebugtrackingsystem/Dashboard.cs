using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace asebugtrackingsystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        RegisterBugSolutionClass bs = new RegisterBugSolutionClass();
        Getalldatatables get = new Getalldatatables();
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgvsearch.DataSource = get.searchBugSolutionByBugDetails(txtsearch.Text);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                dgvsearch.DataSource = get.getAllBugSolutions();

                 lbltotalproject.Text= get.countNumberOfProjects().ToString();
                lbltotalmember.Text = get.totalMember().ToString();
         lbltotalbug.Text = get.getAllBugs().Rows.Count.ToString();
            lblfixedbug.Text=  get.getAllBugSolutions().Rows.Count.ToString();


            }
            catch (Exception ex)
            {


              MessageBox.Show(ex.Message);
            }
        }
    }
}
