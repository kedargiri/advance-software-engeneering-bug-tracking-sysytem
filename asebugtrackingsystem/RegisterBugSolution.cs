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
using System.IO;
using WinFormsSyntaxHighlighter;
using System.Text.RegularExpressions;

namespace asebugtrackingsystem
{
    public partial class RegisterBugSolution : Form
    {
        public RegisterBugSolution()
        {
            InitializeComponent();
            var syntaxHighlighter = new SyntaxHighlighter(txtcode);
            // multi-line comments
            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"/\*(.|[\r\n])*?\*/", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.DarkSeaGreen, false, true));
            // singlie-line comments
            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"//.*?$", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.Green, false, true));
            // numbers
            syntaxHighlighter.AddPattern(new PatternDefinition(@"\d+\.\d+|\d+"), new SyntaxStyle(Color.Purple));
            // double quote strings
            syntaxHighlighter.AddPattern(new PatternDefinition(@"\""([^""]|\""\"")+\"""), new SyntaxStyle(Color.Red));
            // single quote strings
            syntaxHighlighter.AddPattern(new PatternDefinition(@"\'([^']|\'\')+\'"), new SyntaxStyle(Color.Salmon));
            // keywords1
            syntaxHighlighter.AddPattern(new PatternDefinition("for", "foreach", "int", "var"), new SyntaxStyle(Color.Blue));
            // keywords2
            syntaxHighlighter.AddPattern(new CaseInsensitivePatternDefinition("public", "partial", "class", "void"), new SyntaxStyle(Color.Navy, true, false));
            // operators
            syntaxHighlighter.AddPattern(new PatternDefinition("+", "-", ">", "<", "&", "|"), new SyntaxStyle(Color.Brown));
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        Getalldatatables get = new Getalldatatables();
        public int id;
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.manageBugSolutions(0, Convert.ToDateTime(dtpdate.Text), Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbbugdetail.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolution.SelectedValue.ToString()), txtsolution.Text, txtcode.Rtf, 1);
                if(result==true)
                {
                    MessageBox.Show("Bug solution Successfully register");
                    dgvregisterbugsolution.DataSource = get.getAllBugSolutions();
                    HelperClass.MakeFieldBlank(panel2);
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.manageBugSolutions(id, Convert.ToDateTime(dtpdate.Text), Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbbugdetail.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolution.SelectedValue.ToString()), txtsolution.Text, txtcode.Rtf, 2);
                if (result == true)
                {
                    MessageBox.Show("Bug solution Successfully updated");
                    dgvregisterbugsolution.DataSource = get.getAllBugSolutions();
                    HelperClass.MakeFieldBlank(panel2);
                }
                else
                {
                    MessageBox.Show("Error on Updating bug solution details");
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
                bool result = blc.manageBugSolutions(id, Convert.ToDateTime(dtpdate.Text), Convert.ToInt32(cmbproject.SelectedValue.ToString()), Convert.ToInt32(cmbbugdetail.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolution.SelectedValue.ToString()), txtsolution.Text, txtcode.Rtf, 3);
                if (result == true)
                {
                    MessageBox.Show("Bug solution Successfully deleted");
                    dgvregisterbugsolution.DataSource = get.getAllBugSolutions();
                    HelperClass.MakeFieldBlank(panel2);
                }
                else
                {
                    MessageBox.Show("Error on deleting bug solution details");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvregisterbugsolution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvregisterbugsolution.SelectedRows[0].Cells["bugSolutionId"].Value.ToString());
            cmbproject.Text = dgvregisterbugsolution.SelectedRows[0].Cells["projectName"].Value.ToString();
            cmbbugsolution.Text = dgvregisterbugsolution.SelectedRows[0].Cells["memberName"].Value.ToString();
            cmbbugdetail.Text = dgvregisterbugsolution.SelectedRows[0].Cells["bugDetails"].Value.ToString();
            txtsolution.Text = dgvregisterbugsolution.SelectedRows[0].Cells["solutionDetails"].Value.ToString();
            dtpdate.Text = dgvregisterbugsolution.SelectedRows[0].Cells["dateOfSolutionIdentified"].Value.ToString();
            txtcode.Rtf= dgvregisterbugsolution.SelectedRows[0].Cells["codeAfterFixingBug"].Value.ToString();
            MemoryStream memoryStream = new MemoryStream((byte[])dgvregisterbugsolution.SelectedRows[0].Cells["snapShotOfBugMessage"].Value);
            pbscreenshot.Image = Image.FromStream(memoryStream);


        }
    }
}
