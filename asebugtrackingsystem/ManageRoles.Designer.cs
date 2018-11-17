namespace asebugtrackingsystem
{
    partial class ManageRoles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvmanagerole = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanagerole)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Roles";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtdesignation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 302);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designation";
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(143, 21);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(351, 27);
            this.txtdesignation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(143, 89);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(351, 153);
            this.txtdescription.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(18, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 47);
            this.panel2.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(125, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(175, 41);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(301, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(175, 41);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(482, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(175, 41);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvmanagerole);
            this.panel3.Location = new System.Drawing.Point(7, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 225);
            this.panel3.TabIndex = 1;
            // 
            // dgvmanagerole
            // 
            this.dgvmanagerole.AllowUserToAddRows = false;
            this.dgvmanagerole.AllowUserToDeleteRows = false;
            this.dgvmanagerole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmanagerole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanagerole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmanagerole.Location = new System.Drawing.Point(0, 0);
            this.dgvmanagerole.Name = "dgvmanagerole";
            this.dgvmanagerole.ReadOnly = true;
            this.dgvmanagerole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmanagerole.Size = new System.Drawing.Size(780, 223);
            this.dgvmanagerole.TabIndex = 0;
            this.dgvmanagerole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmanagerole_CellClick);
            // 
            // ManageRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 584);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ManageRoles";
            this.Text = "ManageRoles";
            this.Load += new System.EventHandler(this.ManageRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanagerole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvmanagerole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label label1;
    }
}