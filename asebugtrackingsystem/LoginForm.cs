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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        Getalldatatables get = new Getalldatatables();
        BusinessLogicClass blc = new BusinessLogicClass();
        RegisterBug r = new RegisterBug();
        private void btnlogin_Click(object sender, EventArgs e)
        {

            if(txtusername.Text=="")
            {
                MessageBox.Show("Provide UserName");
            }
            else if(txtpassword.Text=="")
                
                {
                MessageBox.Show("Provide Password");
            }
            else
            { 
            try
            {
                string role = get.Login(txtusername.Text, txtpassword.Text);
                if (role == "")
                {
                    MessageBox.Show("invalid Username or Password");
                }
                else
                {
                    if (role == "Project Manager")
                    {
                        MessageBox.Show("Successfully Login as manager");
                        MainForm frm = new MainForm();
                        frm.lblusername.Text = "Welcome " + txtusername.Text;
                        this.Hide();
                        frm.Show();

                    }
                    else if (role == "Developer")
                    {
                        MessageBox.Show("Successfully Login as developer");
                        MainForm frm = new MainForm();
                        frm.lblusername.Text = "Welcome " + txtusername.Text;
                        this.Hide();
                        frm.Show();
                        frm.btnmanagemember.Enabled = false;
                        frm.btnmanageproject.Enabled = false;
                        frm.btnmanageuser.Enabled = false;
                        frm.btnprojectmember.Enabled = false;
                    }
                    else if(role=="Tester")
                    {

                        MessageBox.Show("Successfully Login as Developer");
                        MainForm frm = new MainForm();
                        frm.lblusername.Text = "Welcome" + txtusername.Text;
                        this.Hide();
                        frm.Show();

                    }


                    else
                    {
                        MessageBox.Show("Successfully Logi as tester");
                        MainForm frm = new MainForm();
                        frm.lblusername.Text = "Welcome " + txtusername.Text;
                        this.Hide();
                        frm.Show();
                        frm.btnmanagemember.Enabled = false;
                        frm.btnmanageproject.Enabled = false;
                        frm.btnmanageuser.Enabled = false;
                        frm.btnprojectmember.Enabled = false;
                        frm.button1.Enabled = false;
                        //  RegisterBug bg = new RegisterBug();
                        r.btndelete.Enabled = false;
                       // bg.Show();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        }
        private void txtusername_Enter(object sender, EventArgs e)
        {
            if(txtusername.Text=="User Name")
                {

                txtusername.Text = "";
                txtusername.ForeColor = Color.Black;
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {

                txtusername.Text = "User Name";
                txtusername.ForeColor = Color.Silver;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if(txtpassword.Text=="Password")
            {
                txtpassword.Text = "";
                txtpassword.UseSystemPasswordChar = true;
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if(txtpassword.Text=="")
            {
                txtpassword.Text = "Password";
                txtpassword.UseSystemPasswordChar = true;
                txtpassword.ForeColor = Color.Silver;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //txtPassword.UseSystemPasswordChar = !chkSeePassword.Checked;
            if (chkpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }

          //  txtpassword.UseSystemPasswordChar = chkpassword.Checked;

        }
    }
}
