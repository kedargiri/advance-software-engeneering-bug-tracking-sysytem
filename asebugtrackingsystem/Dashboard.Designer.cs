namespace asebugtrackingsystem
{
    partial class Dashboard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltotalbug = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotalbugfixed = new System.Windows.Forms.Label();
            this.lbltotalmembers = new System.Windows.Forms.Label();
            this.lbltbugregister = new System.Windows.Forms.Label();
            this.lbltotalnumberofproject = new System.Windows.Forms.Label();
            this.dgvsearch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotalproject = new System.Windows.Forms.Label();
            this.lbltotalmember = new System.Windows.Forms.Label();
            this.lblfixedbug = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.lblfixedbug);
            this.panel4.Controls.Add(this.lbltotalmember);
            this.panel4.Controls.Add(this.lbltotalproject);
            this.panel4.Controls.Add(this.lbltotalbug);
            this.panel4.Controls.Add(this.txtsearch);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbltotalbugfixed);
            this.panel4.Controls.Add(this.lbltotalmembers);
            this.panel4.Controls.Add(this.lbltbugregister);
            this.panel4.Controls.Add(this.lbltotalnumberofproject);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 163);
            this.panel4.TabIndex = 15;
            // 
            // lbltotalbug
            // 
            this.lbltotalbug.AutoSize = true;
            this.lbltotalbug.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbug.Location = new System.Drawing.Point(215, 74);
            this.lbltotalbug.Name = "lbltotalbug";
            this.lbltotalbug.Size = new System.Drawing.Size(19, 21);
            this.lbltotalbug.TabIndex = 7;
            this.lbltotalbug.Text = "0";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(628, 17);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(183, 42);
            this.txtsearch.TabIndex = 6;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(491, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search For Bugs:";
            // 
            // lbltotalbugfixed
            // 
            this.lbltotalbugfixed.AutoSize = true;
            this.lbltotalbugfixed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbltotalbugfixed.ForeColor = System.Drawing.Color.Black;
            this.lbltotalbugfixed.Location = new System.Drawing.Point(299, 74);
            this.lbltotalbugfixed.Name = "lbltotalbugfixed";
            this.lbltotalbugfixed.Size = new System.Drawing.Size(157, 21);
            this.lbltotalbugfixed.TabIndex = 2;
            this.lbltotalbugfixed.Text = "TOTAL BUG FIXED : ";
            // 
            // lbltotalmembers
            // 
            this.lbltotalmembers.AutoSize = true;
            this.lbltotalmembers.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbltotalmembers.ForeColor = System.Drawing.Color.Black;
            this.lbltotalmembers.Location = new System.Drawing.Point(299, 28);
            this.lbltotalmembers.Name = "lbltotalmembers";
            this.lbltotalmembers.Size = new System.Drawing.Size(151, 21);
            this.lbltotalmembers.TabIndex = 3;
            this.lbltotalmembers.Text = "TOTAL MEMBERS : ";
            // 
            // lbltbugregister
            // 
            this.lbltbugregister.AutoSize = true;
            this.lbltbugregister.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbltbugregister.ForeColor = System.Drawing.Color.Black;
            this.lbltbugregister.Location = new System.Drawing.Point(6, 74);
            this.lbltbugregister.Name = "lbltbugregister";
            this.lbltbugregister.Size = new System.Drawing.Size(209, 21);
            this.lbltbugregister.TabIndex = 4;
            this.lbltbugregister.Text = "TOTAL BUG REGISTERED :-";
            // 
            // lbltotalnumberofproject
            // 
            this.lbltotalnumberofproject.AutoSize = true;
            this.lbltotalnumberofproject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalnumberofproject.Location = new System.Drawing.Point(3, 27);
            this.lbltotalnumberofproject.Name = "lbltotalnumberofproject";
            this.lbltotalnumberofproject.Size = new System.Drawing.Size(206, 21);
            this.lbltotalnumberofproject.TabIndex = 0;
            this.lbltotalnumberofproject.Text = "Total Number Of Project:-";
            // 
            // dgvsearch
            // 
            this.dgvsearch.AllowUserToAddRows = false;
            this.dgvsearch.AllowUserToDeleteRows = false;
            this.dgvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsearch.Location = new System.Drawing.Point(0, 0);
            this.dgvsearch.Name = "dgvsearch";
            this.dgvsearch.ReadOnly = true;
            this.dgvsearch.Size = new System.Drawing.Size(820, 415);
            this.dgvsearch.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvsearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 415);
            this.panel1.TabIndex = 16;
            // 
            // lbltotalproject
            // 
            this.lbltotalproject.AutoSize = true;
            this.lbltotalproject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalproject.Location = new System.Drawing.Point(215, 27);
            this.lbltotalproject.Name = "lbltotalproject";
            this.lbltotalproject.Size = new System.Drawing.Size(19, 21);
            this.lbltotalproject.TabIndex = 8;
            this.lbltotalproject.Text = "0";
            // 
            // lbltotalmember
            // 
            this.lbltotalmember.AutoSize = true;
            this.lbltotalmember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalmember.Location = new System.Drawing.Point(456, 27);
            this.lbltotalmember.Name = "lbltotalmember";
            this.lbltotalmember.Size = new System.Drawing.Size(19, 21);
            this.lbltotalmember.TabIndex = 9;
            this.lbltotalmember.Text = "0";
            // 
            // lblfixedbug
            // 
            this.lblfixedbug.AutoSize = true;
            this.lblfixedbug.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfixedbug.Location = new System.Drawing.Point(462, 74);
            this.lblfixedbug.Name = "lblfixedbug";
            this.lblfixedbug.Size = new System.Drawing.Size(19, 21);
            this.lblfixedbug.TabIndex = 10;
            this.lblfixedbug.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbltotalbug;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltotalbugfixed;
        private System.Windows.Forms.Label lbltotalmembers;
        private System.Windows.Forms.Label lbltbugregister;
        private System.Windows.Forms.Label lbltotalnumberofproject;
        private System.Windows.Forms.DataGridView dgvsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfixedbug;
        private System.Windows.Forms.Label lbltotalmember;
        private System.Windows.Forms.Label lbltotalproject;
    }
}