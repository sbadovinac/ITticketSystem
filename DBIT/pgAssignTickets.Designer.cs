namespace DBIT
{
    partial class pgAssignTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgAssignTickets));
            this.lstUsers = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUsers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Email,
            this.Type,
            this.Date_Created});
            this.lstUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lstUsers.FullRowSelect = true;
            this.lstUsers.GridLines = true;
            this.lstUsers.Location = new System.Drawing.Point(11, 11);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(406, 456);
            this.lstUsers.TabIndex = 3;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
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
            // pgAssignTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(428, 478);
            this.Controls.Add(this.lstUsers);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pgAssignTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Date_Created;
    }
}