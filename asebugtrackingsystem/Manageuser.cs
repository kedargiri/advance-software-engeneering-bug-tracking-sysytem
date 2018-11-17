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
        public int id;
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                bool a = blc.Manageusers(0, Convert.ToInt32(cmbuserrole.SelectedValue.ToString()), Convert.ToInt32(cmbfullname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 1);
                if(a==true)
                {
                    MessageBox.Show("User Successfully created");
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
            cmbfullname.DataSource = mu.getAllMembers();
            cmbfullname.ValueMember = "memberId";
            cmbfullname.DisplayMember = "memberName";
            cmbfullname.SelectedIndex = -1;
            cmbuserrole.DataSource = mu.getAllUserRoles();
            cmbuserrole.ValueMember = "userRoleId";
            cmbuserrole.DisplayMember = "userRole";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool a = blc.Manageusers(id, Convert.ToInt32(cmbuserrole.SelectedValue.ToString()), Convert.ToInt32(cmbfullname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 2);
                if (a == true)
                {
                    MessageBox.Show("User Successfully updated");
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
    }
}
