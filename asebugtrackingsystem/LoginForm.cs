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
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string role = get.Login(txtusername.Text, txtpassword.Text);
                if (role=="")
                {
                    MessageBox.Show("invalid Username or Password");
                }
                else
                {
                    if(role=="Project Manager")
                    {
                        MessageBox.Show("Successfully Login as manager");
                        MainForm frm = new MainForm();
                        frm.lblusername.Text = "Welcome " + txtusername.Text;
                        this.Hide();
                        frm.Show();
                        
                    }
                    else if (role=="Developer")
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
                        frm.button1.Enabled=false;
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
