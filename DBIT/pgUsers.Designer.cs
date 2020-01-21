namespace DBIT
{
    partial class pgUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgUsers));
            this.UserList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sddbManageTable = new System.Windows.Forms.ToolStripDropDownButton();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterAD = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterIT = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterPM = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterRM = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.btnEditUserType = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Email,
            this.Type,
            this.Date_Created});
            this.UserList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserList.FullRowSelect = true;
            this.UserList.GridLines = true;
            this.UserList.Location = new System.Drawing.Point(0, 23);
            this.UserList.Margin = new System.Windows.Forms.Padding(2);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(404, 431);
            this.UserList.TabIndex = 2;
            this.UserList.UseCompatibleStateImageBehavior = false;
            this.UserList.View = System.Windows.Forms.View.Details;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "User ID";
            this.ID.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // Date_Created
            // 
            this.Date_Created.Text = "DateCreated";
            this.Date_Created.Width = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sddbManageTable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sddbManageTable
            // 
            this.sddbManageTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sddbManageTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.sddbManageTable.Image = ((System.Drawing.Image)(resources.GetObject("sddbManageTable.Image")));
            this.sddbManageTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sddbManageTable.Name = "sddbManageTable";
            this.sddbManageTable.Size = new System.Drawing.Size(94, 22);
            this.sddbManageTable.Text = "Manage Table";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterAD,
            this.FilterIT,
            this.FilterPM,
            this.FilterRM});
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.googleToolStripMenuItem.Text = "Type";
            // 
            // FilterAD
            // 
            this.FilterAD.Name = "FilterAD";
            this.FilterAD.Size = new System.Drawing.Size(180, 22);
            this.FilterAD.Text = "Admin";
            this.FilterAD.Click += new System.EventHandler(this.FilterAD_Click);
            // 
            // FilterIT
            // 
            this.FilterIT.Name = "FilterIT";
            this.FilterIT.Size = new System.Drawing.Size(180, 22);
            this.FilterIT.Text = "IT Specialist";
            this.FilterIT.Click += new System.EventHandler(this.FilterIT_Click);
            // 
            // FilterPM
            // 
            this.FilterPM.Name = "FilterPM";
            this.FilterPM.Size = new System.Drawing.Size(180, 22);
            this.FilterPM.Text = "Program Member";
            this.FilterPM.Click += new System.EventHandler(this.FilterPM_Click);
            // 
            // FilterRM
            // 
            this.FilterRM.Name = "FilterRM";
            this.FilterRM.Size = new System.Drawing.Size(180, 22);
            this.FilterRM.Text = "Report Manager";
            this.FilterRM.Click += new System.EventHandler(this.FilterRM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Created:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(554, 70);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(170, 20);
            this.txtUserID.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(554, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(554, 143);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(170, 20);
            this.txtType.TabIndex = 13;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Location = new System.Drawing.Point(554, 179);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(170, 20);
            this.txtDateCreated.TabIndex = 14;
            // 
            // btnEditUserType
            // 
            this.btnEditUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUserType.Location = new System.Drawing.Point(578, 228);
            this.btnEditUserType.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditUserType.Name = "btnEditUserType";
            this.btnEditUserType.Size = new System.Drawing.Size(122, 37);
            this.btnEditUserType.TabIndex = 15;
            this.btnEditUserType.Text = "Edit User Type";
            this.btnEditUserType.UseVisualStyleBackColor = true;
            this.btnEditUserType.Click += new System.EventHandler(this.btnEditUserType_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Admin",
            "I.T. Specialist",
            "Program Member",
            "Report Manager"});
            this.cbxType.Location = new System.Drawing.Point(552, 140);
            this.cbxType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(172, 21);
            this.cbxType.TabIndex = 16;
            // 
            // pgUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.btnEditUserType);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.UserList);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pgUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView UserList;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Date_Created;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton sddbManageTable;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterAD;
        private System.Windows.Forms.ToolStripMenuItem FilterIT;
        private System.Windows.Forms.ToolStripMenuItem FilterPM;
        private System.Windows.Forms.ToolStripMenuItem FilterRM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.Button btnEditUserType;
        private System.Windows.Forms.ComboBox cbxType;
    }
}