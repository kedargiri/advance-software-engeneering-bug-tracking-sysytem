using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace asebugtrackingsystem
{
    public partial class RegisterBugSolution : Form
    {
        public RegisterBugSolution()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        Getalldatatables get = new Getalldatatables();
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.manageBugSolutions(0, Convert.ToDateTime(dtpdate.Text), Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbbugdetail.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolution.SelectedValue.ToString()), txtsolution.Text, txtcode.Text, 1);
                if(result==true)
                {
                    MessageBox.Show("Bug solution Successfully register");
                }
                else
                {
                    MessageBox.Show("Error on registering bug solution details");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterBugSolution_Load(object sender, EventArgs e)
        {
            dgvregisterbugsolution.DataSource = get.getAllBugSolutions();

            cmbproject.DataSource = get.getAllProjects();
            cmbproject.ValueMember = "projectId";
            cmbproject.DisplayMember = "projectName";
            cmbproject.SelectedIndex = -1;

            cmbbugdetail.DataSource = get.getAllBugs();
            cmbbugdetail.ValueMember = "bugId";
            cmbbugdetail.DisplayMember = "bugDetails";
            cmbbugdetail.SelectedIndex = -1;

            cmbbugsolution.DataSource = get.getAllMembers();
            cmbbugsolution.ValueMember = "memberId";
            cmbbugsolution.DisplayMember = "memberName";
            cmbbugsolution.SelectedIndex = -1;
        }
    }
}
