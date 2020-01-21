namespace DBIT
{
    partial class pgTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgTickets));
            this.TicketList = new System.Windows.Forms.ListView();
            this.CaseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Issue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateSolved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssignedTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Solution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sddbManageTable = new System.Windows.Forms.ToolStripDropDownButton();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterSolved = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterUnsolved = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterMyTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterUnassigned = new System.Windows.Forms.ToolStripMenuItem();
            this.anyPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priority1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priority2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priority3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterAssigned = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateCreatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFirstToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recentLastToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateSolvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetTable = new System.Windows.Forms.ToolStripButton();
            this.btnAddTick = new System.Windows.Forms.ToolStripButton();
            this.btnusers = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnRegisterNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerateReport = new System.Windows.Forms.ToolStripButton();
            this.btnhelp = new System.Windows.Forms.ToolStripButton();
            this.btnfaq = new System.Windows.Forms.ToolStripButton();
            this.lblUserID = new System.Windows.Forms.Label();
            this.AssignedUserIDtxt = new System.Windows.Forms.TextBox();
            this.btnAssignedTicketUser = new System.Windows.Forms.Button();
            this.lblTicketInformation = new System.Windows.Forms.Label();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblAssignedWorker = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDateSolved = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.CaseIDtxt = new System.Windows.Forms.TextBox();
            this.OwnerIDtxt = new System.Windows.Forms.TextBox();
            this.DateCreatedtxt = new System.Windows.Forms.TextBox();
            this.Headertxt = new System.Windows.Forms.TextBox();
            this.AssignedTotxt = new System.Windows.Forms.TextBox();
            this.Prioritytxt = new System.Windows.Forms.TextBox();
            this.DateSolvedtxt = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.Descriptiontxt = new System.Windows.Forms.RichTextBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.txtModified = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Solutiontxt = new System.Windows.Forms.RichTextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnReAssign = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnReopen = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketList
            // 
            this.TicketList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.TicketList.AllowColumnReorder = true;
            this.TicketList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TicketList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TicketList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CaseID,
            this.owner,
            this.Issue,
            this.Description,
            this.DateCreated,
            this.DateSolved,
            this.DateModified,
            this.Priority,
            this.AssignedTo,
            this.Solution});
            this.TicketList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TicketList.FullRowSelect = true;
            this.TicketList.GridLines = true;
            this.TicketList.Location = new System.Drawing.Point(15, 25);
            this.TicketList.Margin = new System.Windows.Forms.Padding(2);
            this.TicketList.Name = "TicketList";
            this.TicketList.Size = new System.Drawing.Size(922, 723);
            this.TicketList.TabIndex = 1;
            this.TicketList.UseCompatibleStateImageBehavior = false;
            this.TicketList.View = System.Windows.Forms.View.Details;
            this.TicketList.SelectedIndexChanged += new System.EventHandler(this.TicketList_SelectedIndexChanged);
            // 
            // CaseID
            // 
            this.CaseID.Text = "Case ID";
            this.CaseID.Width = 50;
            // 
            // owner
            // 
            this.owner.Text = "Owner";
            this.owner.Width = 114;
            // 
            // Issue
            // 
            this.Issue.Text = "Issue";
            this.Issue.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 132;
            // 
            // DateCreated
            // 
            this.DateCreated.Text = "Created";
            this.DateCreated.Width = 100;
            // 
            // DateSolved
            // 
            this.DateSolved.Text = "Solved";
            this.DateSolved.Width = 100;
            // 
            // DateModified
            // 
            this.DateModified.Text = "Last Modified";
            this.DateModified.Width = 100;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 70;
            // 
            // AssignedTo
            // 
            this.AssignedTo.Text = "Assigned To";
            this.AssignedTo.Width = 100;
            // 
            // Solution
            // 
            this.Solution.Text = "Solution";
            this.Solution.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sddbManageTable,
            this.ResetTable,
            this.btnAddTick,
            this.btnusers,
            this.btnGenerateReport,
            this.btnhelp,
            this.btnfaq});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1472, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sddbManageTable
            // 
            this.sddbManageTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sddbManageTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.sortByToolStripMenuItem});
            this.sddbManageTable.Image = ((System.Drawing.Image)(resources.GetObject("sddbManageTable.Image")));
            this.sddbManageTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sddbManageTable.Name = "sddbManageTable";
            this.sddbManageTable.Size = new System.Drawing.Size(46, 22);
            this.sddbManageTable.Text = "Filter";
            this.sddbManageTable.ToolTipText = "Filter";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterSolved,
            this.FilterUnsolved,
            this.FilterMyTickets,
            this.FilterUnassigned,
            this.FilterAssigned});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // FilterSolved
            // 
            this.FilterSolved.Name = "FilterSolved";
            this.FilterSolved.Size = new System.Drawing.Size(175, 22);
            this.FilterSolved.Text = "Solved";
            this.FilterSolved.Click += new System.EventHandler(this.FilterSolved_Click);
            // 
            // FilterUnsolved
            // 
            this.FilterUnsolved.Name = "FilterUnsolved";
            this.FilterUnsolved.Size = new System.Drawing.Size(175, 22);
            this.FilterUnsolved.Text = "Unsolved";
            this.FilterUnsolved.Click += new System.EventHandler(this.FilterUnsolved_Click);
            // 
            // FilterMyTickets
            // 
            this.FilterMyTickets.Name = "FilterMyTickets";
            this.FilterMyTickets.Size = new System.Drawing.Size(175, 22);
            this.FilterMyTickets.Text = "My Tickets";
            this.FilterMyTickets.Click += new System.EventHandler(this.FilterMyTickets_Click);
            // 
            // FilterUnassigned
            // 
            this.FilterUnassigned.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anyPriorityToolStripMenuItem,
            this.priority1ToolStripMenuItem,
            this.priority2ToolStripMenuItem,
            this.priority3ToolStripMenuItem});
            this.FilterUnassigned.Name = "FilterUnassigned";
            this.FilterUnassigned.Size = new System.Drawing.Size(175, 22);
            this.FilterUnassigned.Text = "Unassigned Tickets";
            // 
            // anyPriorityToolStripMenuItem
            // 
            this.anyPriorityToolStripMenuItem.Name = "anyPriorityToolStripMenuItem";
            this.anyPriorityToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.anyPriorityToolStripMenuItem.Text = "Any Priority";
            this.anyPriorityToolStripMenuItem.Click += new System.EventHandler(this.FilterAllPriority_Click);
            // 
            // priority1ToolStripMenuItem
            // 
            this.priority1ToolStripMenuItem.Name = "priority1ToolStripMenuItem";
            this.priority1ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.priority1ToolStripMenuItem.Text = "Priority 1";
            this.priority1ToolStripMenuItem.Click += new System.EventHandler(this.FilterPriority1_Click);
            // 
            // priority2ToolStripMenuItem
            // 
            this.priority2ToolStripMenuItem.Name = "priority2ToolStripMenuItem";
            this.priority2ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.priority2ToolStripMenuItem.Text = "Priority 2";
            this.priority2ToolStripMenuItem.Click += new System.EventHandler(this.FilterPriority2_Click);
            // 
            // priority3ToolStripMenuItem
            // 
            this.priority3ToolStripMenuItem.Name = "priority3ToolStripMenuItem";
            this.priority3ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.priority3ToolStripMenuItem.Text = "Priority 3";
            this.priority3ToolStripMenuItem.Click += new System.EventHandler(this.FilterPriority3_Click);
            // 
            // FilterAssigned
            // 
            this.FilterAssigned.Name = "FilterAssigned";
            this.FilterAssigned.Size = new System.Drawing.Size(175, 22);
            this.FilterAssigned.Text = "Assigned Tickets";
            this.FilterAssigned.Click += new System.EventHandler(this.FilterAssigned_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.iDToolStripMenuItem,
            this.dateCreatedToolStripMenuItem,
            this.dateSolvedToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sortByToolStripMenuItem.Text = "Sort By";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminFirstToolStripMenuItem,
            this.iTFirstToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.typeToolStripMenuItem.Text = "Owner";
            // 
            // adminFirstToolStripMenuItem
            // 
            this.adminFirstToolStripMenuItem.Name = "adminFirstToolStripMenuItem";
            this.adminFirstToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.adminFirstToolStripMenuItem.Text = "Ascending";
            this.adminFirstToolStripMenuItem.Click += new System.EventHandler(this.Sort_Owner_Asc);
            // 
            // iTFirstToolStripMenuItem
            // 
            this.iTFirstToolStripMenuItem.Name = "iTFirstToolStripMenuItem";
            this.iTFirstToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.iTFirstToolStripMenuItem.Text = "Descending";
            this.iTFirstToolStripMenuItem.Click += new System.EventHandler(this.Sort_Owner_Desc);
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.iDToolStripMenuItem.Text = "ID";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.Sort_CaseID_Asc);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.Sort_CaseID_Desc);
            // 
            // dateCreatedToolStripMenuItem
            // 
            this.dateCreatedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentFirstToolStripMenuItem1,
            this.recentLastToolStripMenuItem1});
            this.dateCreatedToolStripMenuItem.Name = "dateCreatedToolStripMenuItem";
            this.dateCreatedToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dateCreatedToolStripMenuItem.Text = "Date Created";
            // 
            // recentFirstToolStripMenuItem1
            // 
            this.recentFirstToolStripMenuItem1.Name = "recentFirstToolStripMenuItem1";
            this.recentFirstToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.recentFirstToolStripMenuItem1.Text = "Recent First";
            this.recentFirstToolStripMenuItem1.Click += new System.EventHandler(this.Sort_DateCreated_Asc);
            // 
            // recentLastToolStripMenuItem1
            // 
            this.recentLastToolStripMenuItem1.Name = "recentLastToolStripMenuItem1";
            this.recentLastToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.recentLastToolStripMenuItem1.Text = "Recent Last";
            this.recentLastToolStripMenuItem1.Click += new System.EventHandler(this.Sort_DateCreated_Desc);
            // 
            // dateSolvedToolStripMenuItem
            // 
            this.dateSolvedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentFirstToolStripMenuItem,
            this.recentLastToolStripMenuItem});
            this.dateSolvedToolStripMenuItem.Name = "dateSolvedToolStripMenuItem";
            this.dateSolvedToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dateSolvedToolStripMenuItem.Text = "Date Solved";
            // 
            // recentFirstToolStripMenuItem
            // 
            this.recentFirstToolStripMenuItem.Name = "recentFirstToolStripMenuItem";
            this.recentFirstToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.recentFirstToolStripMenuItem.Text = "Recent First";
            this.recentFirstToolStripMenuItem.Click += new System.EventHandler(this.Sort_DateSolved_Asc);
            // 
            // recentLastToolStripMenuItem
            // 
            this.recentLastToolStripMenuItem.Name = "recentLastToolStripMenuItem";
            this.recentLastToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.recentLastToolStripMenuItem.Text = "Recent Last";
            this.recentLastToolStripMenuItem.Click += new System.EventHandler(this.Sort_DateSolved_Desc);
            // 
            // ResetTable
            // 
            this.ResetTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResetTable.Image = ((System.Drawing.Image)(resources.GetObject("ResetTable.Image")));
            this.ResetTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetTable.Name = "ResetTable";
            this.ResetTable.Size = new System.Drawing.Size(70, 22);
            this.ResetTable.Text = "Reset Table";
            this.ResetTable.Click += new System.EventHandler(this.btnResetTable_Click);
            // 
            // btnAddTick
            // 
            this.btnAddTick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddTick.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTick.Image")));
            this.btnAddTick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTick.Name = "btnAddTick";
            this.btnAddTick.Size = new System.Drawing.Size(68, 22);
            this.btnAddTick.Text = "Add Ticket";
            this.btnAddTick.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnusers
            // 
            this.btnusers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnusers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegisterNewUser,
            this.btnListUser});
            this.btnusers.Image = ((System.Drawing.Image)(resources.GetObject("btnusers.Image")));
            this.btnusers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(43, 22);
            this.btnusers.Text = "User";
            // 
            // btnRegisterNewUser
            // 
            this.btnRegisterNewUser.Name = "btnRegisterNewUser";
            this.btnRegisterNewUser.Size = new System.Drawing.Size(169, 22);
            this.btnRegisterNewUser.Text = "Register New User";
            this.btnRegisterNewUser.Click += new System.EventHandler(this.btnRegisterNewUser_Click);
            // 
            // btnListUser
            // 
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Size = new System.Drawing.Size(169, 22);
            this.btnListUser.Text = "List of Users";
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(96, 22);
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnhelp.Image = ((System.Drawing.Image)(resources.GetObject("btnhelp.Image")));
            this.btnhelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(36, 22);
            this.btnhelp.Text = "Help";
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btnfaq
            // 
            this.btnfaq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnfaq.Image = ((System.Drawing.Image)(resources.GetObject("btnfaq.Image")));
            this.btnfaq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnfaq.Name = "btnfaq";
            this.btnfaq.Size = new System.Drawing.Size(33, 22);
            this.btnfaq.Text = "FAQ";
            this.btnfaq.Click += new System.EventHandler(this.btnfaq_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(989, 55);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(54, 13);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "User ID:";
            // 
            // AssignedUserIDtxt
            // 
            this.AssignedUserIDtxt.Location = new System.Drawing.Point(1047, 53);
            this.AssignedUserIDtxt.Margin = new System.Windows.Forms.Padding(2);
            this.AssignedUserIDtxt.Name = "AssignedUserIDtxt";
            this.AssignedUserIDtxt.Size = new System.Drawing.Size(76, 20);
            this.AssignedUserIDtxt.TabIndex = 9;
            // 
            // btnAssignedTicketUser
            // 
            this.btnAssignedTicketUser.Location = new System.Drawing.Point(1127, 49);
            this.btnAssignedTicketUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignedTicketUser.Name = "btnAssignedTicketUser";
            this.btnAssignedTicketUser.Size = new System.Drawing.Size(134, 26);
            this.btnAssignedTicketUser.TabIndex = 10;
            this.btnAssignedTicketUser.Text = "Show User\'s Tickets";
            this.btnAssignedTicketUser.UseVisualStyleBackColor = true;
            this.btnAssignedTicketUser.Click += new System.EventHandler(this.btnAssignedTicketUser_Click);
            // 
            // lblTicketInformation
            // 
            this.lblTicketInformation.AutoSize = true;
            this.lblTicketInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketInformation.Location = new System.Drawing.Point(995, 92);
            this.lblTicketInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketInformation.Name = "lblTicketInformation";
            this.lblTicketInformation.Size = new System.Drawing.Size(202, 26);
            this.lblTicketInformation.TabIndex = 11;
            this.lblTicketInformation.Text = "Ticket Information";
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseID.Location = new System.Drawing.Point(1024, 128);
            this.lblCaseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(60, 13);
            this.lblCaseID.TabIndex = 12;
            this.lblCaseID.Text = "Case ID: ";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerID.Location = new System.Drawing.Point(1028, 151);
            this.lblOwnerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(47, 13);
            this.lblOwnerID.TabIndex = 13;
            this.lblOwnerID.Text = "Owner:";
            this.lblOwnerID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 14;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(1028, 245);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(41, 13);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "Issue:";
            // 
            // lblAssignedWorker
            // 
            this.lblAssignedWorker.AutoSize = true;
            this.lblAssignedWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedWorker.Location = new System.Drawing.Point(997, 199);
            this.lblAssignedWorker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignedWorker.Name = "lblAssignedWorker";
            this.lblAssignedWorker.Size = new System.Drawing.Size(81, 13);
            this.lblAssignedWorker.TabIndex = 16;
            this.lblAssignedWorker.Text = "Assigned To:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(1028, 174);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(50, 13);
            this.lblPriority.TabIndex = 17;
            this.lblPriority.Text = "Priority:";
            // 
            // lblDateSolved
            // 
            this.lblDateSolved.AutoSize = true;
            this.lblDateSolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSolved.Location = new System.Drawing.Point(1249, 128);
            this.lblDateSolved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateSolved.Name = "lblDateSolved";
            this.lblDateSolved.Size = new System.Drawing.Size(50, 13);
            this.lblDateSolved.TabIndex = 18;
            this.lblDateSolved.Text = "Solved:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.Location = new System.Drawing.Point(1244, 154);
            this.lblDateCreated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(55, 13);
            this.lblDateCreated.TabIndex = 19;
            this.lblDateCreated.Text = "Created:";
            // 
            // CaseIDtxt
            // 
            this.CaseIDtxt.Location = new System.Drawing.Point(1083, 121);
            this.CaseIDtxt.Margin = new System.Windows.Forms.Padding(2);
            this.CaseIDtxt.Name = "CaseIDtxt";
            this.CaseIDtxt.ReadOnly = true;
            this.CaseIDtxt.Size = new System.Drawing.Size(40, 20);
            this.CaseIDtxt.TabIndex = 20;
            // 
            // OwnerIDtxt
            // 
            this.OwnerIDtxt.Location = new System.Drawing.Point(1083, 147);
            this.OwnerIDtxt.Margin = new System.Windows.Forms.Padding(2);
            this.OwnerIDtxt.Name = "OwnerIDtxt";
            this.OwnerIDtxt.ReadOnly = true;
            this.OwnerIDtxt.Size = new System.Drawing.Size(104, 20);
            this.OwnerIDtxt.TabIndex = 21;
            // 
            // DateCreatedtxt
            // 
            this.DateCreatedtxt.Location = new System.Drawing.Point(1303, 151);
            this.DateCreatedtxt.Margin = new System.Windows.Forms.Padding(2);
            this.DateCreatedtxt.Name = "DateCreatedtxt";
            this.DateCreatedtxt.ReadOnly = true;
            this.DateCreatedtxt.Size = new System.Drawing.Size(104, 20);
            this.DateCreatedtxt.TabIndex = 22;
            // 
            // Headertxt
            // 
            this.Headertxt.Location = new System.Drawing.Point(1083, 242);
            this.Headertxt.Margin = new System.Windows.Forms.Padding(2);
            this.Headertxt.Name = "Headertxt";
            this.Headertxt.ReadOnly = true;
            this.Headertxt.Size = new System.Drawing.Size(288, 20);
            this.Headertxt.TabIndex = 23;
            // 
            // AssignedTotxt
            // 
            this.AssignedTotxt.Location = new System.Drawing.Point(1083, 195);
            this.AssignedTotxt.Margin = new System.Windows.Forms.Padding(2);
            this.AssignedTotxt.Name = "AssignedTotxt";
            this.AssignedTotxt.ReadOnly = true;
            this.AssignedTotxt.Size = new System.Drawing.Size(104, 20);
            this.AssignedTotxt.TabIndex = 24;
            // 
            // Prioritytxt
            // 
            this.Prioritytxt.Location = new System.Drawing.Point(1083, 171);
            this.Prioritytxt.Margin = new System.Windows.Forms.Padding(2);
            this.Prioritytxt.Name = "Prioritytxt";
            this.Prioritytxt.ReadOnly = true;
            this.Prioritytxt.Size = new System.Drawing.Size(104, 20);
            this.Prioritytxt.TabIndex = 25;
            // 
            // DateSolvedtxt
            // 
            this.DateSolvedtxt.Location = new System.Drawing.Point(1303, 125);
            this.DateSolvedtxt.Margin = new System.Windows.Forms.Padding(2);
            this.DateSolvedtxt.Name = "DateSolvedtxt";
            this.DateSolvedtxt.ReadOnly = true;
            this.DateSolvedtxt.Size = new System.Drawing.Size(104, 20);
            this.DateSolvedtxt.TabIndex = 26;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(997, 269);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 13);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Description:";
            // 
            // Descriptiontxt
            // 
            this.Descriptiontxt.Location = new System.Drawing.Point(1083, 266);
            this.Descriptiontxt.Margin = new System.Windows.Forms.Padding(2);
            this.Descriptiontxt.Name = "Descriptiontxt";
            this.Descriptiontxt.ReadOnly = true;
            this.Descriptiontxt.Size = new System.Drawing.Size(288, 136);
            this.Descriptiontxt.TabIndex = 28;
            this.Descriptiontxt.Text = "";
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(1166, 524);
            this.Editbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(131, 25);
            this.Editbtn.TabIndex = 29;
            this.Editbtn.Text = "Save Changes";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtModified
            // 
            this.txtModified.Location = new System.Drawing.Point(1303, 178);
            this.txtModified.Margin = new System.Windows.Forms.Padding(2);
            this.txtModified.Name = "txtModified";
            this.txtModified.ReadOnly = true;
            this.txtModified.Size = new System.Drawing.Size(104, 20);
            this.txtModified.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1212, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Last Modified:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1012, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Solution:";
            // 
            // Solutiontxt
            // 
            this.Solutiontxt.Location = new System.Drawing.Point(1083, 407);
            this.Solutiontxt.Name = "Solutiontxt";
            this.Solutiontxt.ReadOnly = true;
            this.Solutiontxt.Size = new System.Drawing.Size(288, 77);
            this.Solutiontxt.TabIndex = 33;
            this.Solutiontxt.Text = "";
            // 
            // btnAssign
            // 
            this.btnAssign.Enabled = false;
            this.btnAssign.Location = new System.Drawing.Point(1247, 573);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(128, 25);
            this.btnAssign.TabIndex = 34;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnReAssign
            // 
            this.btnReAssign.Enabled = false;
            this.btnReAssign.Location = new System.Drawing.Point(1247, 615);
            this.btnReAssign.Name = "btnReAssign";
            this.btnReAssign.Size = new System.Drawing.Size(128, 23);
            this.btnReAssign.TabIndex = 35;
            this.btnReAssign.Text = "Reassign";
            this.btnReAssign.UseVisualStyleBackColor = true;
            this.btnReAssign.Click += new System.EventHandler(this.btnReAssign_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(1082, 573);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(131, 25);
            this.btnSolve.TabIndex = 36;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnReopen
            // 
            this.btnReopen.Location = new System.Drawing.Point(1082, 615);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(131, 23);
            this.btnReopen.TabIndex = 37;
            this.btnReopen.Text = "Reopen Ticket";
            this.btnReopen.UseVisualStyleBackColor = true;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // pgTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1472, 756);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnReAssign);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.Solutiontxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModified);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Descriptiontxt);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.DateSolvedtxt);
            this.Controls.Add(this.Prioritytxt);
            this.Controls.Add(this.AssignedTotxt);
            this.Controls.Add(this.Headertxt);
            this.Controls.Add(this.DateCreatedtxt);
            this.Controls.Add(this.OwnerIDtxt);
            this.Controls.Add(this.CaseIDtxt);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblDateSolved);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblAssignedWorker);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblCaseID);
            this.Controls.Add(this.lblTicketInformation);
            this.Controls.Add(this.btnAssignedTicketUser);
            this.Controls.Add(this.AssignedUserIDtxt);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TicketList);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pgTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView TicketList;
        private System.Windows.Forms.ColumnHeader CaseID;
        private System.Windows.Forms.ColumnHeader owner;
        private System.Windows.Forms.ColumnHeader Issue;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader DateCreated;
        private System.Windows.Forms.ColumnHeader DateSolved;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ColumnHeader AssignedTo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton sddbManageTable;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterSolved;
        private System.Windows.Forms.ToolStripMenuItem FilterUnsolved;
        private System.Windows.Forms.ToolStripMenuItem FilterMyTickets;
        private System.Windows.Forms.ToolStripMenuItem FilterUnassigned;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateCreatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterAssigned;
        private System.Windows.Forms.ToolStripButton ResetTable;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox AssignedUserIDtxt;
        private System.Windows.Forms.Button btnAssignedTicketUser;
        private System.Windows.Forms.Label lblTicketInformation;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblAssignedWorker;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDateSolved;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.TextBox CaseIDtxt;
        private System.Windows.Forms.TextBox OwnerIDtxt;
        private System.Windows.Forms.TextBox DateCreatedtxt;
        private System.Windows.Forms.TextBox Headertxt;
        private System.Windows.Forms.TextBox AssignedTotxt;
        private System.Windows.Forms.TextBox Prioritytxt;
        private System.Windows.Forms.TextBox DateSolvedtxt;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox Descriptiontxt;
        private System.Windows.Forms.ToolStripMenuItem recentFirstToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recentLastToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateSolvedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentLastToolStripMenuItem;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.ColumnHeader DateModified;
        private System.Windows.Forms.TextBox txtModified;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Solution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Solutiontxt;
        private System.Windows.Forms.Button btnAssign;
		private System.Windows.Forms.Button btnReAssign;
		private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnReopen;
		private System.Windows.Forms.ToolStripMenuItem anyPriorityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem priority1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem priority2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem priority3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnAddTick;
        private System.Windows.Forms.ToolStripDropDownButton btnusers;
        private System.Windows.Forms.ToolStripMenuItem btnRegisterNewUser;
        private System.Windows.Forms.ToolStripMenuItem btnListUser;
        private System.Windows.Forms.ToolStripButton btnGenerateReport;
        private System.Windows.Forms.ToolStripButton btnhelp;
        private System.Windows.Forms.ToolStripButton btnfaq;
    }
}