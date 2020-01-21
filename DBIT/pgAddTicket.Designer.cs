namespace DBIT
{
    partial class pgAddTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgAddTicket));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescOfIssue = new System.Windows.Forms.Label();
            this.cbxCommon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.Location = new System.Drawing.Point(347, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Ticket";
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmitTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmitTicket.Location = new System.Drawing.Point(532, 318);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(120, 58);
            this.btnSubmitTicket.TabIndex = 1;
            this.btnSubmitTicket.Text = "Submit Ticket";
            this.btnSubmitTicket.UseVisualStyleBackColor = true;
            this.btnSubmitTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHeader
            // 
            this.txtHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHeader.Location = new System.Drawing.Point(232, 151);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(420, 20);
            this.txtHeader.TabIndex = 2;
            // 
            // lblIssue
            // 
            this.lblIssue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIssue.Location = new System.Drawing.Point(174, 149);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(52, 20);
            this.lblIssue.TabIndex = 3;
            this.lblIssue.Text = "Issue:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(232, 188);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(420, 114);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            // 
            // lblDescOfIssue
            // 
            this.lblDescOfIssue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescOfIssue.AutoSize = true;
            this.lblDescOfIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescOfIssue.Location = new System.Drawing.Point(33, 188);
            this.lblDescOfIssue.Name = "lblDescOfIssue";
            this.lblDescOfIssue.Size = new System.Drawing.Size(193, 20);
            this.lblDescOfIssue.TabIndex = 5;
            this.lblDescOfIssue.Text = "Please describe the issue:";
            // 
            // cbxCommon
            // 
            this.cbxCommon.FormattingEnabled = true;
            this.cbxCommon.Items.AddRange(new object[] {
            "I can\'t connect to the internet",
            "I can\'t login",
            "I accidentally deleted some files",
            "My printer won\'t work"});
            this.cbxCommon.Location = new System.Drawing.Point(232, 104);
            this.cbxCommon.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCommon.Name = "cbxCommon";
            this.cbxCommon.Size = new System.Drawing.Size(282, 21);
            this.cbxCommon.TabIndex = 6;
            this.cbxCommon.SelectedIndexChanged += new System.EventHandler(this.cbxCommon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Common Issues:";
            // 
            // pgAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCommon);
            this.Controls.Add(this.lblDescOfIssue);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.btnSubmitTicket);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pgAddTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblDescOfIssue;
        private System.Windows.Forms.ComboBox cbxCommon;
        private System.Windows.Forms.Label label1;
    }
}