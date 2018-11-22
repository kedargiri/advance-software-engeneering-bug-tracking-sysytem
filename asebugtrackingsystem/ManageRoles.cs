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
using BusinessLogicLayer;

namespace asebugtrackingsystem
{
    public partial class ManageRoles : Form
    {
        public ManageRoles()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        ManageRole mr = new ManageRole();
        Getalldatatables get = new Getalldatatables();
        public int id;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtdescription.Text=="")
            {
                MessageBox.Show("Provide Description");
            }
            else if(txtdesignation.Text=="")
            {
                MessageBox.Show("Provide Designation");
            }
            else { 
            try
            {
                bool x = blc.ManageRoles(0, txtdesignation.Text, txtdescription.Text,1);
                if (x == true)
                {
                    MessageBox.Show("User Successfull created");
                    dgvmanagerole.DataSource = get.getalluserroles();
                    HelperClass.MakeFieldBlank(panel1);

                }
                else
                    MessageBox.Show("Error on creating user");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        }
        private void ManageRoles_Load(object sender, EventArgs e)
        {
            dgvmanagerole.DataSource = get.getalluserroles();
        }

        private void dgvmanagerole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvmanagerole.SelectedRows[0].Cells["userRoleId"].Value.ToString());
            txtdesignation.Text = dgvmanagerole.SelectedRows[0].Cells["userRole"].Value.ToString();
            txtdescription.Text = dgvmanagerole.SelectedRows[0].Cells["roleDescription"].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool x = blc.ManageRoles(id, txtdesignation.Text, txtdescription.Text, 2);
                if (x == true)
                {
                    MessageBox.Show("User Successfull Updated");
                    dgvmanagerole.DataSource = get.getalluserroles();
                    HelperClass.MakeFieldBlank(panel1);

                }
                else
                    MessageBox.Show("Error on updating user");
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
                bool x = blc.ManageRoles(id, txtdesignation.Text, txtdescription.Text, 3);
                if (x == true)
                {
                    MessageBox.Show("User Successfull Deleted");
                    dgvmanagerole.DataSource = get.getalluserroles();
                    HelperClass.MakeFieldBlank(panel1);

                }
                else
                    MessageBox.Show("Error on deleting user");
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
