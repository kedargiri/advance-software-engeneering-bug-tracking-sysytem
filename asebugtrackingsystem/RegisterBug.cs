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
    public partial class RegisterBug : Form
    {
        public RegisterBug()
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
        int id;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.manageBugs(0,Convert.ToDateTime(dtpdate.Text), Convert.ToInt32(cmbidentifiedbug.SelectedValue.ToString()), Convert.ToInt32(cmbproject.SelectedValue.ToString()), txtclassliabrary.Text,txtclass.Text, txtmethord.Text, txtblock.Text, txtlinenumber.Text, txtbugdetails.Text, HelperClass.imageConverter(pbsecrreshoterror), txtcode.Rtf, 1);
                if (result == true)
                {
                    MessageBox.Show("Successfull on adding bug");
                    HelperClass.MakeFieldBlank(panel1);
                    dgvbugentry.DataSource = get.getAllBugs();
                }
                else
                {
                    MessageBox.Show("Error on Adding Bug Details");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterBug_Load(object sender, EventArgs e)
        {
           dgvbugentry.DataSource = get.getAllBugs();
           cmbidentifiedbug.DataSource = get.getAllMembers();
            cmbidentifiedbug.DisplayMember = "memberName";
            cmbidentifiedbug.ValueMember = "memberId";
            cmbidentifiedbug.SelectedIndex = -1;
            cmbproject.DataSource = get.getAllProjects();
           cmbproject.ValueMember = "projectId";
            cmbproject.DisplayMember = "projectName";
            cmbproject.SelectedIndex = -1;
        }

        private void txtbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbsecrreshoterror.Image = Image.FromFile(ofd.FileName);

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

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.manageBugs(id, Convert.ToDateTime(dtpdate.Text), Convert.ToInt32(cmbidentifiedbug.SelectedValue.ToString()), Convert.ToInt32(cmbproject.SelectedValue.ToString()), txtclassliabrary.Text, txtclass.Text, txtmethord.Text, txtblock.Text, txtlinenumber.Text, txtbugdetails.Text, HelperClass.imageConverter(pbsecrreshoterror), txtcode.Rtf, 2);
                if (result == true)
                {
                    MessageBox.Show("Successfull on updating bug");
                    HelperClass.MakeFieldBlank(panel1);
                    dgvbugentry.DataSource = get.getAllBugs();
                }
                else
                {
                    MessageBox.Show("Error on updating bug");
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
                bool result = blc.manageBugs(id, Convert.ToDateTime(dtpdate.Text), Convert.ToInt32(cmbidentifiedbug.SelectedValue.ToString()), Convert.ToInt32(cmbproject.SelectedValue.ToString()), txtclassliabrary.Text, txtclass.Text, txtmethord.Text, txtblock.Text, txtlinenumber.Text, txtbugdetails.Text, HelperClass.imageConverter(pbsecrreshoterror), txtcode.Rtf, 3);
                if (result == true)
                {
                    MessageBox.Show("Successfull on deleting bug details");
                    HelperClass.MakeFieldBlank(panel1);
                    dgvbugentry.DataSource = get.getAllBugs();
                }
                else
                {
                    MessageBox.Show("Error on deleting Bug Details");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvbugentry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvbugentry.SelectedRows[0].Cells["bugId"].Value.ToString());
                dtpdate.Text = dgvbugentry.SelectedRows[0].Cells["bugIdentifiedDate"].Value.ToString();
                cmbidentifiedbug.Text = dgvbugentry.SelectedRows[0].Cells["memberName"].Value.ToString();
                cmbproject.Text = dgvbugentry.SelectedRows[0].Cells["projectName"].Value.ToString();
                txtclassliabrary.Text = dgvbugentry.SelectedRows[0].Cells["classLibraryName"].Value.ToString();
                txtclass.Text = dgvbugentry.SelectedRows[0].Cells["className"].Value.ToString();
                txtmethord.Text = dgvbugentry.SelectedRows[0].Cells["methodName"].Value.ToString();
                txtblock.Text = dgvbugentry.SelectedRows[0].Cells["blockName"].Value.ToString();
                txtlinenumber.Text = dgvbugentry.SelectedRows[0].Cells["lineNumber"].Value.ToString();
                txtbugdetails.Text = dgvbugentry.SelectedRows[0].Cells["bugDetails"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvbugentry.SelectedRows[0].Cells["snapShotOfBugMessage"].Value);
                pbsecrreshoterror.Image = Image.FromStream(memoryStream);
                txtcode.Rtf = dgvbugentry.SelectedRows[0].Cells["codeContainingBug"].Value.ToString();
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

