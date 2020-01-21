namespace DBIT
{
    partial class pgLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgLogin));
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxLogin.Controls.Add(this.lblRegister);
            this.gbxLogin.Controls.Add(this.lblInstructions);
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.txtPassword);
            this.gbxLogin.Controls.Add(this.txtUsername);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.lblUsername);
            this.gbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbxLogin.ForeColor = System.Drawing.Color.Blue;
            this.gbxLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(349, 225);
            this.gbxLogin.TabIndex = 0;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(22, 189);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(62, 13);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.Text = "Not a user?";
            this.lblRegister.Visible = false;
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblInstructions.Location = new System.Drawing.Point(102, 42);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(148, 13);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Please enter login credentials.";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogin.Location = new System.Drawing.Point(122, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPassword.Location = new System.Drawing.Point(83, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUsername.Location = new System.Drawing.Point(83, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPassword.Location = new System.Drawing.Point(24, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblUsername.Location = new System.Drawing.Point(22, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // pgLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(373, 249);
            this.Controls.Add(this.gbxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragonball IT Login";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblRegister;
    }
}