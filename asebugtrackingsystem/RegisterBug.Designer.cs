namespace asebugtrackingsystem
{
    partial class RegisterBug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvbugentry = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbrowse = new System.Windows.Forms.Button();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbugdetails = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlinenumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbsecrreshoterror = new System.Windows.Forms.PictureBox();
            this.txtblock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmethord = new System.Windows.Forms.TextBox();
            this.txtclassliabrary = new System.Windows.Forms.TextBox();
            this.cmbproject = new System.Windows.Forms.ComboBox();
            this.cmbidentifiedbug = new System.Windows.Forms.ComboBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbugentry)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsecrreshoterror)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 568);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bug Entry";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvbugentry);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 457);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(806, 108);
            this.panel5.TabIndex = 3;
            // 
            // dgvbugentry
            // 
            this.dgvbugentry.AllowUserToAddRows = false;
            this.dgvbugentry.AllowUserToDeleteRows = false;
            this.dgvbugentry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbugentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbugentry.Location = new System.Drawing.Point(3, -3);
            this.dgvbugentry.Name = "dgvbugentry";
            this.dgvbugentry.ReadOnly = true;
            this.dgvbugentry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbugentry.Size = new System.Drawing.Size(806, 111);
            this.dgvbugentry.TabIndex = 0;
            this.dgvbugentry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbugentry_CellClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Controls.Add(this.btnedit);
            this.panel4.Controls.Add(this.btnadd);
            this.panel4.Location = new System.Drawing.Point(9, 419);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 36);
            this.panel4.TabIndex = 2;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(460, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(119, 29);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(335, 4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(119, 29);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(210, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(119, 29);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtcode);
            this.panel3.Location = new System.Drawing.Point(63, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 66);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Code";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtbrowse);
            this.panel1.Controls.Add(this.txtclass);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtbugdetails);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtlinenumber);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtblock);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtmethord);
            this.panel1.Controls.Add(this.txtclassliabrary);
            this.panel1.Controls.Add(this.cmbproject);
            this.panel1.Controls.Add(this.cmbidentifiedbug);
            this.panel1.Controls.Add(this.dtpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 314);
            this.panel1.TabIndex = 0;
            // 
            // txtbrowse
            // 
            this.txtbrowse.Location = new System.Drawing.Point(581, 272);
            this.txtbrowse.Name = "txtbrowse";
            this.txtbrowse.Size = new System.Drawing.Size(144, 29);
            this.txtbrowse.TabIndex = 17;
            this.txtbrowse.Text = "Browse";
            this.txtbrowse.UseVisualStyleBackColor = true;
            this.txtbrowse.Click += new System.EventHandler(this.txtbrowse_Click);
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(150, 163);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(221, 27);
            this.txtclass.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Class";
            // 
            // txtbugdetails
            // 
            this.txtbugdetails.Location = new System.Drawing.Point(554, 239);
            this.txtbugdetails.Name = "txtbugdetails";
            this.txtbugdetails.Size = new System.Drawing.Size(221, 27);
            this.txtbugdetails.TabIndex = 16;
            this.txtbugdetails.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Bug Details";
            // 
            // txtlinenumber
            // 
            this.txtlinenumber.Location = new System.Drawing.Point(150, 277);
            this.txtlinenumber.Name = "txtlinenumber";
            this.txtlinenumber.Size = new System.Drawing.Size(221, 27);
            this.txtlinenumber.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Line Number";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbsecrreshoterror);
            this.panel2.Location = new System.Drawing.Point(419, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 221);
            this.panel2.TabIndex = 12;
            // 
            // pbsecrreshoterror
            // 
            this.pbsecrreshoterror.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbsecrreshoterror.Location = new System.Drawing.Point(0, 0);
            this.pbsecrreshoterror.Name = "pbsecrreshoterror";
            this.pbsecrreshoterror.Size = new System.Drawing.Size(355, 219);
            this.pbsecrreshoterror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsecrreshoterror.TabIndex = 0;
            this.pbsecrreshoterror.TabStop = false;
            // 
            // txtblock
            // 
            this.txtblock.Location = new System.Drawing.Point(150, 237);
            this.txtblock.Name = "txtblock";
            this.txtblock.Size = new System.Drawing.Size(221, 27);
            this.txtblock.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Block";
            // 
            // txtmethord
            // 
            this.txtmethord.Location = new System.Drawing.Point(150, 197);
            this.txtmethord.Name = "txtmethord";
            this.txtmethord.Size = new System.Drawing.Size(221, 27);
            this.txtmethord.TabIndex = 9;
            // 
            // txtclassliabrary
            // 
            this.txtclassliabrary.Location = new System.Drawing.Point(150, 123);
            this.txtclassliabrary.Name = "txtclassliabrary";
            this.txtclassliabrary.Size = new System.Drawing.Size(221, 27);
            this.txtclassliabrary.TabIndex = 8;
            // 
            // cmbproject
            // 
            this.cmbproject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproject.FormattingEnabled = true;
            this.cmbproject.Location = new System.Drawing.Point(150, 87);
            this.cmbproject.Name = "cmbproject";
            this.cmbproject.Size = new System.Drawing.Size(221, 29);
            this.cmbproject.TabIndex = 7;
            // 
            // cmbidentifiedbug
            // 
            this.cmbidentifiedbug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbidentifiedbug.FormattingEnabled = true;
            this.cmbidentifiedbug.Location = new System.Drawing.Point(150, 47);
            this.cmbidentifiedbug.Name = "cmbidentifiedbug";
            this.cmbidentifiedbug.Size = new System.Drawing.Size(221, 29);
            this.cmbidentifiedbug.TabIndex = 6;
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(75, 8);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(296, 27);
            this.dtpdate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class Liabrary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identified Bug By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // txtcode
            // 
            this.txtcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcode.Location = new System.Drawing.Point(0, 0);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(736, 64);
            this.txtcode.TabIndex = 12;
            this.txtcode.Text = "";
            // 
            // RegisterBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 584);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegisterBug";
            this.Text = "RegisterBug";
            this.Load += new System.EventHandler(this.RegisterBug_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbugentry)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbsecrreshoterror)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvbugentry;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbsecrreshoterror;
        private System.Windows.Forms.TextBox txtblock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmethord;
        private System.Windows.Forms.TextBox txtclassliabrary;
        private System.Windows.Forms.ComboBox cmbproject;
        private System.Windows.Forms.ComboBox cmbidentifiedbug;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbugdetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtlinenumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtbrowse;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtcode;
    }
}