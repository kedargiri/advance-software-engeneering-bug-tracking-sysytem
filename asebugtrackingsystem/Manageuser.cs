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
    public partial class Manageuser : Form
    {
        public Manageuser()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        ManageUser mu = new ManageUser();
        Getalldatatables get = new Getalldatatables();
        public int id;
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                bool a = blc.Manageusers(0, Convert.ToInt32(cmbuserrole.SelectedValue.ToString()), Convert.ToInt32(cmbfullname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 1);
                if(a==true)
                {
                    MessageBox.Show("User Successfully created");
                    HelperClass.MakeFieldBlank(panel1);
                }
                else
                {
                    MessageBox.Show("error on creating user");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Manageuser_Load(object sender, EventArgs e)
        {
            dgvgetallusers.DataSource = get.getAllUsers();
            cmbfullname.DataSource = get.getAllMembers();
            cmbfullname.ValueMember = "memberId";
            cmbfullname.DisplayMember = "memberName";
            cmbfullname.SelectedIndex = -1;
            cmbuserrole.DataSource = get.getAllUserRoles();
            cmbuserrole.ValueMember = "userRoleId";
            cmbuserrole.DisplayMember = "userRole";
            cmbuserrole.SelectedIndex = -1;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool a = blc.Manageusers(id, Convert.ToInt32(cmbuserrole.SelectedValue.ToString()), Convert.ToInt32(cmbfullname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 2);
                if (a == true)
                {
                    MessageBox.Show("User Successfully updated");
                    dgvgetallusers.DataSource = get.getAllUsers();
                    HelperClass.MakeFieldBlank(panel1);
                }
                else
                {
                    MessageBox.Show("error on creating user");
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
                bool a = blc.Manageusers(id, Convert.ToInt32(cmbuserrole.SelectedValue.ToString()), Convert.ToInt32(cmbfullname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 3);
                if (a == true)
                {
                    MessageBox.Show("User Successfully Deleted");
                    HelperClass.MakeFieldBlank(panel1);
                }
                else
                {
                    MessageBox.Show("error on deleting user");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvgetallusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvgetallusers.SelectedRows[0].Cells["Id"].Value.ToString());
            //cmbUserRole.Text = dgvUserInformation.SelectedRows[0].Cells["Role"].Value.ToString();
            // cmbFullName.Text = dgvUserInformation.SelectedRows[0].Cells["Name"].Value.ToString();
            // txtUserName.Text = dgvUserInformation.SelectedRows[0].Cells["Username"].Value.ToString();
            // txtPassword.Text = dgvUserInformation.SelectedRows[0].Cells["Password"].Value.ToString();
            // txtCPassword.Text = dgvUserInformation.SelectedRows[0].Cells["Password"].Value.ToString();

            cmbuserrole.Text = dgvgetallusers.SelectedRows[0].Cells["Role"].Value.ToString();
            cmbfullname.Text = dgvgetallusers.SelectedRows[0].Cells["Name"].Value.ToString();
            txtusername.Text = dgvgetallusers.SelectedRows[0].Cells["Username"].Value.ToString();
            txtpassword.Text = dgvgetallusers.SelectedRows[0].Cells["Password"].Value.ToString();
            txtconformpassword.Text = dgvgetallusers.SelectedRows[0].Cells["Password"].Value.ToString();

        }
    }
}
