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
    public partial class ProjectMember : Form
    {
        public ProjectMember()
        {
            InitializeComponent();
        }
        ProjectMemberClass pp = new ProjectMemberClass();
        Getalldatatables get = new Getalldatatables();
        BusinessLogicClass blc = new BusinessLogicClass();
          int id;

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtdescription.Text == "")
            {
                MessageBox.Show("provide Description");
            }
            else if (cmbmember.Text == "")
            {
                MessageBox.Show("Select member");
            }
            else if (cmbmemberrole.Text == "")
            {
                MessageBox.Show("Select Member Role");
            }
            else if (cmbproject.Text == "")
            {
                MessageBox.Show("Select Project");
            }
            else { 




            try
            {
                bool result = blc.manageProjectMembers(0, Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbmemberrole.SelectedValue.ToString()), cmbmember.Text, txtdescription.Text, 1);

                if(result==true)
                {
                    MessageBox.Show("successfully Project Member Created");
                    dgvprojectmember.DataSource = get.getAllMembersInProject();
                    HelperClass.MakeFieldBlank(panel1);
                }
                else
                {
                    MessageBox.Show("Error on creating Project Member");
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.manageProjectMembers(id, Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbmemberrole.SelectedValue.ToString()), cmbmember.Text, txtdescription.Text, 2);

                if (result == true)
                {
                    MessageBox.Show("Project Member successfully updated");
                    dgvprojectmember.DataSource = get.getAllMembersInProject();
                    HelperClass.MakeFieldBlank(panel1);
                }
                else
                {
                    MessageBox.Show("Error on Updating Project Member");
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.manageProjectMembers(id, Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbmemberrole.SelectedValue.ToString()), cmbmember.Text, txtdescription.Text, 3);

                if (result == true)
                {
                    MessageBox.Show("successfully deleted Project Member");
                    dgvprojectmember.DataSource = get.getAllMembersInProject();
                    HelperClass.MakeFieldBlank(panel1);
                }
                else
                {
                    MessageBox.Show("Error on deleting Project Member");
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectMember_Load(object sender, EventArgs e)
        {
            dgvprojectmember.DataSource = get.getAllMembersInProject();

            cmbmember.DataSource = get.getAllMembers();
            cmbmember.ValueMember = "memberId";
            cmbmember.DisplayMember = "memberName";
            cmbmember.SelectedIndex = -1;

            cmbproject.DataSource = get.getAllProjects();
            cmbproject.ValueMember = "projectId";
            cmbproject.DisplayMember = "projectName";
            cmbproject.SelectedIndex = -1;

            cmbmemberrole.DataSource = get.getAllUserRoles();
            cmbmemberrole.ValueMember = "userRoleId";
            cmbmemberrole.DisplayMember = "userRole";
            cmbmemberrole.SelectedIndex = -1;
        }

        private void dgvprojectmember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvprojectmember.SelectedRows[0].Cells["id"].Value.ToString());
                cmbproject.Text = dgvprojectmember.SelectedRows[0].Cells["projectName"].Value.ToString();
                cmbmember.Text = dgvprojectmember.SelectedRows[0].Cells["memberName"].Value.ToString();
               cmbmemberrole.Text = dgvprojectmember.SelectedRows[0].Cells["memberRole"].Value.ToString();
                txtdescription.Text = dgvprojectmember.SelectedRows[0].Cells["memberResponsibilities"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
    

