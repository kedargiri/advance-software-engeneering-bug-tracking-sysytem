using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asebugtrackingsystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            pnldisplay.Controls.Clear();
            Dashboard frm = new Dashboard();
            frm.TopLevel = false;
            pnldisplay.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnldisplay.Controls.Clear();
            Manageuser mu = new Manageuser();
            mu.TopLevel = false;
            pnldisplay.Controls.Add(mu);
            mu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnldisplay.Controls.Clear();
            ManageMember mm = new ManageMember();
            mm.TopLevel = false;
            pnldisplay.Controls.Add(mm);
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnldisplay.Controls.Clear();
            ProjectManagement pm = new ProjectManagement();
            pm.TopLevel = false;
            pnldisplay.Controls.Add(pm);
            pm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnldisplay.Controls.Clear();
            ProjectMember pmm = new ProjectMember();
            pmm.TopLevel = false;
            pnldisplay.Controls.Add(pmm);
            pmm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnldisplay.Controls.Clear();
            RegisterBug rg = new RegisterBug();
            rg.TopLevel = false;
            pnldisplay.Controls.Add(rg);
            rg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnldisplay.Controls.Clear();
            RegisterBugSolution rbs = new RegisterBugSolution();
            rbs.TopLevel = false;
            pnldisplay.Controls.Add(rbs);
            rbs.Show();
        }
    }
}
