namespace DBIT
{
    partial class pgRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgRegister));
            this.lblNewUserEmail = new System.Windows.Forms.Label();
            this.lblNewUserType = new System.Windows.Forms.Label();
            this.txtNewUserEmail = new System.Windows.Forms.TextBox();
            this.cmbNewUserType = new System.Windows.Forms.ComboBox();
            this.btnSubmitNewUser = new System.Windows.Forms.Button();
            this.gbxRegister = new System.Windows.Forms.GroupBox();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.txtNewUserPassword = new System.Windows.Forms.TextBox();
            this.lblRnewUserEmail = new System.Windows.Forms.Label();
            this.gbxRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewUserEmail
            // 
            this.lblNewUserEmail.AutoSize = true;
            this.lblNewUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNewUserEmail.Location = new System.Drawing.Point(25, 81);
            this.lblNewUserEmail.Name = "lblNewUserEmail";
            this.lblNewUserEmail.Size = new System.Drawing.Size(53, 13);
            this.lblNewUserEmail.TabIndex = 0;
            this.lblNewUserEmail.Text = "Password";
            // 
            // lblNewUserType
            // 
            this.lblNewUserType.AutoSize = true;
            this.lblNewUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNewUserType.Location = new System.Drawing.Point(25, 116);
            this.lblNewUserType.Name = "lblNewUserType";
            this.lblNewUserType.Size = new System.Drawing.Size(29, 13);
            this.lblNewUserType.TabIndex = 1;
            this.lblNewUserType.Text = "Role";
            // 
            // txtNewUserEmail
            // 
            this.txtNewUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNewUserEmail.Location = new System.Drawing.Point(137, 46);
            this.txtNewUserEmail.Name = "txtNewUserEmail";
            this.txtNewUserEmail.Size = new System.Drawing.Size(205, 20);
            this.txtNewUserEmail.TabIndex = 0;
            // 
            // cmbNewUserType
            // 
            this.cmbNewUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbNewUserType.FormattingEnabled = true;
            this.cmbNewUserType.Items.AddRange(new object[] {
            "Admin",
            "Program Member",
            "Report Manager",
            "I.T. Specialist"});
            this.cmbNewUserType.Location = new System.Drawing.Point(137, 114);
            this.cmbNewUserType.Name = "cmbNewUserType";
            this.cmbNewUserType.Size = new System.Drawing.Size(205, 21);
            this.cmbNewUserType.TabIndex = 2;
            // 
            // btnSubmitNewUser
            // 
            this.btnSubmitNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSubmitNewUser.Location = new System.Drawing.Point(185, 153);
            this.btnSubmitNewUser.Name = "btnSubmitNewUser";
            this.btnSubmitNewUser.Size = new System.Drawing.Size(100, 30);
            this.btnSubmitNewUser.TabIndex = 3;
            this.btnSubmitNewUser.Text = "Submit New User";
            this.btnSubmitNewUser.UseVisualStyleBackColor = true;
            this.btnSubmitNewUser.Click += new System.EventHandler(this.btnSubmitNewUser_Click);
            // 
            // gbxRegister
            // 
            this.gbxRegister.Controls.Add(this.cbxEmail);
            this.gbxRegister.Controls.Add(this.txtNewUserPassword);
            this.gbxRegister.Controls.Add(this.lblRnewUserEmail);
            this.gbxRegister.Controls.Add(this.btnSubmitNewUser);
            this.gbxRegister.Controls.Add(this.txtNewUserEmail);
            this.gbxRegister.Controls.Add(this.lblNewUserEmail);
            this.gbxRegister.Controls.Add(this.cmbNewUserType);
            this.gbxRegister.Controls.Add(this.lblNewUserType);
            this.gbxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbxRegister.ForeColor = System.Drawing.Color.Blue;
            this.gbxRegister.Location = new System.Drawing.Point(12, 12);
            this.gbxRegister.Name = "gbxRegister";
            this.gbxRegister.Size = new System.Drawing.Size(360, 217);
            this.gbxRegister.TabIndex = 6;
            this.gbxRegister.TabStop = false;
            this.gbxRegister.Text = "Register New User";
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.Checked = true;
            this.cbxEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxEmail.Location = new System.Drawing.Point(162, 188);
            this.cbxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(140, 17);
            this.cbxEmail.TabIndex = 4;
            this.cbxEmail.Text = "Send comfirmation email";
            this.cbxEmail.UseVisualStyleBackColor = true;
            // 
            // txtNewUserPassword
            // 
            this.txtNewUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNewUserPassword.Location = new System.Drawing.Point(137, 79);
            this.txtNewUserPassword.Name = "txtNewUserPassword";
            this.txtNewUserPassword.PasswordChar = '*';
            this.txtNewUserPassword.Size = new System.Drawing.Size(205, 20);
            this.txtNewUserPassword.TabIndex = 1;
            // 
            // lblRnewUserEmail
            // 
            this.lblRnewUserEmail.AutoSize = true;
            this.lblRnewUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRnewUserEmail.Location = new System.Drawing.Point(25, 48);
            this.lblRnewUserEmail.Name = "lblRnewUserEmail";
            this.lblRnewUserEmail.Size = new System.Drawing.Size(32, 13);
            this.lblRnewUserEmail.TabIndex = 5;
            this.lblRnewUserEmail.Text = "Email";
            // 
            // pgRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 240);
            this.Controls.Add(this.gbxRegister);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pgRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.gbxRegister.ResumeLayout(false);
            this.gbxRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNewUserEmail;
        private System.Windows.Forms.Label lblNewUserType;
        private System.Windows.Forms.TextBox txtNewUserEmail;
        private System.Windows.Forms.ComboBox cmbNewUserType;
        private System.Windows.Forms.Button btnSubmitNewUser;
        private System.Windows.Forms.GroupBox gbxRegister;
        private System.Windows.Forms.TextBox txtNewUserPassword;
        private System.Windows.Forms.Label lblRnewUserEmail;
		private System.Windows.Forms.CheckBox cbxEmail;
	}
}