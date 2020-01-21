namespace DBIT
{
    partial class pgMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgMain));
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewTickets = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddTicket.Location = new System.Drawing.Point(3, 3);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(180, 70);
            this.btnAddTicket.TabIndex = 0;
            this.btnAddTicket.Text = "Add Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddTicket);
            this.flowLayoutPanel1.Controls.Add(this.btnViewTickets);
            this.flowLayoutPanel1.Controls.Add(this.btnRegister);
            this.flowLayoutPanel1.Controls.Add(this.btnUsers);
            this.flowLayoutPanel1.Controls.Add(this.btnFAQ);
            this.flowLayoutPanel1.Controls.Add(this.btnHelp);
            this.flowLayoutPanel1.Controls.Add(this.btnReport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 346);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnViewTickets
            // 
            this.btnViewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnViewTickets.Location = new System.Drawing.Point(189, 3);
            this.btnViewTickets.Name = "btnViewTickets";
            this.btnViewTickets.Size = new System.Drawing.Size(180, 70);
            this.btnViewTickets.TabIndex = 1;
            this.btnViewTickets.Text = "View Tickets";
            this.btnViewTickets.UseVisualStyleBackColor = true;
            this.btnViewTickets.Click += new System.EventHandler(this.btnViewTickets_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRegister.Location = new System.Drawing.Point(375, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(180, 70);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register User";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUsers.Location = new System.Drawing.Point(561, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(180, 70);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "List of Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnFAQ
            // 
            this.btnFAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFAQ.Location = new System.Drawing.Point(3, 79);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(180, 70);
            this.btnFAQ.TabIndex = 5;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHelp.Location = new System.Drawing.Point(189, 79);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(180, 70);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReport.Location = new System.Drawing.Point(375, 79);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(180, 70);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeaderName.Location = new System.Drawing.Point(206, 34);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(355, 26);
            this.lblHeaderName.TabIndex = 2;
            this.lblHeaderName.Text = "Dragon Ball IT Ticketing Application";
            this.lblHeaderName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pgMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeaderName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pgMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnViewTickets;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Button btnReport;
    }
}