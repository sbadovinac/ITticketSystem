namespace DBIT
{
    partial class pgFAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgFAQ));
            this.faqWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // faqWebBrowser
            // 
            this.faqWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faqWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.faqWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.faqWebBrowser.Name = "faqWebBrowser";
            this.faqWebBrowser.Size = new System.Drawing.Size(800, 450);
            this.faqWebBrowser.TabIndex = 0;
            this.faqWebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // pgFAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.faqWebBrowser);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pgFAQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequently Asked Questions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser faqWebBrowser;
    }
}