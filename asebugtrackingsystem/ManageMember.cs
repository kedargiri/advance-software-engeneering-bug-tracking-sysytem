using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataAccessLayer;
using BusinessLogicLayer;

namespace asebugtrackingsystem
{
    public partial class ManageMember : Form
    {
        public ManageMember()
        {
            InitializeComponent();
        }
        ManageMemberClass mmc = new ManageMemberClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        Getalldatatables get = new Getalldatatables();
        public int id;
        private void btnbrowse_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbprofilepicture.Image = Image.FromFile(ofd.FileName);

                }
                else
                {
                    MessageBox.Show("Please select a profile picture");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (txtmembername.Text == "")
            {
                MessageBox.Show("provide Member Name");
            }
            else if (txtmemberaddress.Text == "")
            {
                MessageBox.Show("Provide Member Address");

            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Provide Email address");
            }

            else if (txtcontact.Text == "")
            {
                MessageBox.Show("Provide Contact Number");
            }
            else if (txtdescription.Text == "")
            {
                MessageBox.Show("Provide Description");
            }
            else if (cmbgender.Text=="")
            {
                MessageBox.Show("Provide gender");
            }
            else { 


                try
            {
                bool x = blc.ManageMembers(0, txtmembername.Text, txtmemberaddress.Text, txtcontact.Text, txtemail.Text, cmbgender.Text, Convert.ToDateTime(dtpdateofbirth.Text), Convert.ToDateTime(dtpdateofjoin.Text), txtdescription.Text, HelperClass.imageConverter(pbprofilepicture), 1);
                if (x == true)
                {
                    MessageBox.Show("NEW MEMBER HAS SUCCESSFULLY CREATED");
                    dgvmanagemember.DataSource = get.getAllMembers();
                    HelperClass.MakeFieldBlank(panel1);
                    pbprofilepicture.Image = null;
                }
                else
                    MessageBox.Show("Error on creating New Member");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        }

        private void ManageMember_Load(object sender, EventArgs e)
        {
            dgvmanagemember.DataSource = get.getAllMembers();
        }

        private void dgvmanagemember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvmanagemember.SelectedRows[0].Cells["memberId"].Value.ToString());
            txtmembername.Text = dgvmanagemember.SelectedRows[0].Cells["memberName"].Value.ToString();
            txtmemberaddress.Text = dgvmanagemember.SelectedRows[0].Cells["memberAddress"].Value.ToString();
            txtcontact.Text = dgvmanagemember.SelectedRows[0].Cells["contactNumber"].Value.ToString();
            cmbgender.Text = dgvmanagemember.SelectedRows[0].Cells["gender"].Value.ToString();
            dtpdateofjoin.Text = dgvmanagemember.SelectedRows[0].Cells["dateOfJoin"].Value.ToString();
            dtpdateofbirth.Text = dgvmanagemember.SelectedRows[0].Cells["dateOfBirth"].Value.ToString();
            txtdescription.Text = dgvmanagemember.SelectedRows[0].Cells["memberDesignation"].Value.ToString();
            txtemail.Text = dgvmanagemember.SelectedRows[0].Cells["emailAddress"].Value.ToString();

            MemoryStream memoryStream = new MemoryStream((byte[])dgvmanagemember.SelectedRows[0].Cells["profilePicture"].Value);
            pbprofilepicture.Image = Image.FromStream(memoryStream);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool x = blc.ManageMembers(id, txtmembername.Text, txtmemberaddress.Text, txtcontact.Text, txtemail.Text, cmbgender.Text, Convert.ToDateTime(dtpdateofbirth.Text), Convert.ToDateTime(dtpdateofjoin.Text), txtdescription.Text, HelperClass.imageConverter(pbprofilepicture), 2);
                if (x == true)
                {
                    MessageBox.Show("MEMBER was SUCCESSFULLY updated");
                    dgvmanagemember.DataSource = get.getAllMembers();
                    HelperClass.MakeFieldBlank(panel1);
                    pbprofilepicture.Image = null;
                }
                else
                    MessageBox.Show("Error on creating New Member");
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
                bool x = blc.ManageMembers(id, txtmembername.Text, txtmemberaddress.Text, txtcontact.Text, txtemail.Text, cmbgender.Text, Convert.ToDateTime(dtpdateofbirth.Text), Convert.ToDateTime(dtpdateofjoin.Text), txtdescription.Text, HelperClass.imageConverter(pbprofilepicture), 3);
                if (x == true)
                {
                    MessageBox.Show("NEW MEMBER HAS SUCCESSFULLY CREATED");
                    dgvmanagemember.DataSource = get.getAllMembers();
                    HelperClass.MakeFieldBlank(panel1);
                    pbprofilepicture.Image = null;
                }
                else
                    MessageBox.Show("Error on creating New Member");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
