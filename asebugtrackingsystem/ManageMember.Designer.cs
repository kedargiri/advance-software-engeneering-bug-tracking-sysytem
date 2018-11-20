namespace asebugtrackingsystem
{
    partial class ManageMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMember));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbprofilepicture = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.dtpdateofjoin = new System.Windows.Forms.DateTimePicker();
            this.dtpdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtmemberaddress = new System.Windows.Forms.TextBox();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvmanagemember = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofilepicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanagemember)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Member";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtpdateofjoin);
            this.panel1.Controls.Add(this.dtpdateofbirth);
            this.panel1.Controls.Add(this.cmbgender);
            this.panel1.Controls.Add(this.txtcontact);
            this.panel1.Controls.Add(this.txtmemberaddress);
            this.panel1.Controls.Add(this.txtmembername);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 357);
            this.panel1.TabIndex = 0;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(192, 288);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(331, 56);
            this.txtdescription.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Description";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(192, 139);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(294, 27);
            this.txtemail.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email:-";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btninsert);
            this.panel2.Controls.Add(this.btnbrowse);
            this.panel2.Location = new System.Drawing.Point(529, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 300);
            this.panel2.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pbprofilepicture);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 138);
            this.panel4.TabIndex = 4;
            // 
            // pbprofilepicture
            // 
            this.pbprofilepicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbprofilepicture.Image = ((System.Drawing.Image)(resources.GetObject("pbprofilepicture.Image")));
            this.pbprofilepicture.Location = new System.Drawing.Point(0, 0);
            this.pbprofilepicture.Name = "pbprofilepicture";
            this.pbprofilepicture.Size = new System.Drawing.Size(216, 136);
            this.pbprofilepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbprofilepicture.TabIndex = 0;
            this.pbprofilepicture.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(13, 256);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(190, 36);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(13, 219);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(190, 36);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(13, 180);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(190, 36);
            this.btninsert.TabIndex = 2;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(13, 142);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(190, 36);
            this.btnbrowse.TabIndex = 1;
            this.btnbrowse.Text = "Browse Image";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // dtpdateofjoin
            // 
            this.dtpdateofjoin.Location = new System.Drawing.Point(192, 253);
            this.dtpdateofjoin.Name = "dtpdateofjoin";
            this.dtpdateofjoin.Size = new System.Drawing.Size(294, 27);
            this.dtpdateofjoin.TabIndex = 23;
            // 
            // dtpdateofbirth
            // 
            this.dtpdateofbirth.Location = new System.Drawing.Point(192, 220);
            this.dtpdateofbirth.Name = "dtpdateofbirth";
            this.dtpdateofbirth.Size = new System.Drawing.Size(294, 27);
            this.dtpdateofbirth.TabIndex = 22;
            // 
            // cmbgender
            // 
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(192, 176);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(294, 29);
            this.cmbgender.TabIndex = 21;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(192, 101);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(294, 27);
            this.txtcontact.TabIndex = 20;
            // 
            // txtmemberaddress
            // 
            this.txtmemberaddress.Location = new System.Drawing.Point(192, 59);
            this.txtmemberaddress.Name = "txtmemberaddress";
            this.txtmemberaddress.Size = new System.Drawing.Size(294, 27);
            this.txtmemberaddress.TabIndex = 19;
            // 
            // txtmembername
            // 
            this.txtmembername.Location = new System.Drawing.Point(192, 26);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(294, 27);
            this.txtmembername.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date Of Join:-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Of Birth:-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gender:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contact no:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Member Address:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Member Name:-";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvmanagemember);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 184);
            this.panel3.TabIndex = 2;
            // 
            // dgvmanagemember
            // 
            this.dgvmanagemember.AllowUserToAddRows = false;
            this.dgvmanagemember.AllowUserToDeleteRows = false;
            this.dgvmanagemember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmanagemember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanagemember.Location = new System.Drawing.Point(0, -7);
            this.dgvmanagemember.Name = "dgvmanagemember";
            this.dgvmanagemember.ReadOnly = true;
            this.dgvmanagemember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmanagemember.Size = new System.Drawing.Size(820, 188);
            this.dgvmanagemember.TabIndex = 0;
            this.dgvmanagemember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmanagemember_CellClick);
            // 
            // ManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageMember";
            this.Text = "ManageMember";
            this.Load += new System.EventHandler(this.ManageMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbprofilepicture)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanagemember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox pbprofilepicture;
        private System.Windows.Forms.DateTimePicker dtpdateofjoin;
        private System.Windows.Forms.DateTimePicker dtpdateofbirth;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtmemberaddress;
        private System.Windows.Forms.TextBox txtmembername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvmanagemember;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label8;
    }
}