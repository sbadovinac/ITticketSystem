using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBIT
{
    public partial class pgTickets : Form
    {
        public Form RefToLogin { get; set; }
        public List<Form> openForms { get; set; }
        List<Ticket> tickets;

		public pgTickets()
        {
            InitializeComponent();
            openForms = new List<Form>();

            // Allow admin to edit readonly fields
            // Setting up admin access
            switch (User.current.type)
            {
                case "AD":
                    Editbtn.Visible = true;
                    CaseIDtxt.ReadOnly = false;
                    OwnerIDtxt.ReadOnly = false;
                    Headertxt.ReadOnly = false;
                    Descriptiontxt.ReadOnly = false;
                    Prioritytxt.ReadOnly = false;
                    AssignedTotxt.ReadOnly = false;
                    break;
                case "PM":
                    btnListUser.Enabled = false;
                    btnRegisterNewUser.Enabled = false;
                    btnGenerateReport.Visible = false;
                    Editbtn.Visible = false;
                    break;
                case "IT":
                    btnRegisterNewUser.Enabled = false;
                    btnGenerateReport.Visible = false;
                    Editbtn.Visible = false;
                    break;
                case "RM":
                    btnAddTick.Visible = false;
                    btnRegisterNewUser.Enabled = false;
                    Editbtn.Visible = true;
                    CaseIDtxt.ReadOnly = false;
                    OwnerIDtxt.ReadOnly = false;
                    Headertxt.ReadOnly = false;
                    Descriptiontxt.ReadOnly = false;
                    Prioritytxt.ReadOnly = false;
                    AssignedTotxt.ReadOnly = false;
                    break;
                default:
                    break;
            }
            btnSolve.Enabled = false;
            btnReopen.Enabled = false;

            btnAssign.Enabled = false; // No selected ticket yet, so this wouldn't make sense.
            btnReAssign.Enabled = false;
            Solutiontxt.ReadOnly = true;

            TicketList.Items.Clear();
            if (User.current.type.Equals("PM"))
            {
                FilterMyTickets_Click("", new EventArgs());
            } else
            {
                populateTableNoFilter();
            }
        }

    // Useful functions to be used in event handlers
        // Adds all tickets to the tables
        private void populateTableNoFilter()
        {
            tickets = Ticket.GetAll();
            // Traverse ticket list and display into the table view
            foreach (var ticket in tickets)
            {
                string[] ticketStrings = ticket.toStringArray();
                ListViewItem item = new ListViewItem(ticketStrings);
                TicketList.Items.Add(item);
            }
        }
		// Adds all tickets to the tables in a sorted order
		private void populateTableSort()
		{
			//tickets = Ticket.GetAllSorted(Identifier);
			// Traverse ticket list and display into the table view
			foreach (var ticket in tickets)
			{
				string[] ticketStrings = ticket.toStringArray();
				ListViewItem item = new ListViewItem(ticketStrings);
				TicketList.Items.Add(item);
			}
		}
        // Fills the text boxes with the selected ticket information
        private void populateDetails()
        {
            Ticket selected = getSelectedTicket();
            if (selected != null)
            {
                string[] strings = selected.toStringArray();
                CaseIDtxt.Text = strings[0];
                OwnerIDtxt.Text = strings[1];
                Headertxt.Text = strings[2];
                Descriptiontxt.Text = strings[3];
                DateCreatedtxt.Text = strings[4];
                DateSolvedtxt.Text = strings[5];
                txtModified.Text = strings[6];
                Prioritytxt.Text = strings[7];
                AssignedTotxt.Text = strings[8];
                Solutiontxt.Text = strings[9];
            }
        }
        // Gets the ticket object that corresponds with user selection
        private Ticket getSelectedTicket()
        {
            if (TicketList.SelectedItems.Count == 0)
            {
                return null;
            }

            int index = TicketList.SelectedIndices[0];
            return tickets[index];
        }
        // Generates a ticket from the details in the details pane
        private Ticket getDetailsTicket()
        {
            Ticket detailedTicket = null;
            try
            {
                string[] str = new string[10];
                str[0] = CaseIDtxt.Text;
                str[1] = OwnerIDtxt.Text;
                str[2] = Headertxt.Text;
                str[3] = Descriptiontxt.Text;
                str[4] = DateCreatedtxt.Text;
                str[5] = DateSolvedtxt.Text;
                str[6] = txtModified.Text;
                str[7] = Prioritytxt.Text;
                str[8] = AssignedTotxt.Text;
                str[9] = Solutiontxt.Text;
					
                detailedTicket = Ticket.fromStringArray(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was error adding details to ticket.\n" + ex.ToString());
            }
            return detailedTicket;
        }

// Event handlers
		private void TicketList_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnSolve.Enabled = false;
			// Solutiontxt.ReadOnly = false;
			btnAssign.Enabled = false;
			btnReAssign.Enabled = false;
            btnSolve.Enabled = false;
			populateDetails();
			Ticket selected = getSelectedTicket();

			if (selected != null)
			{
				String[] ticket = selected.toStringArray();

				if (User.current.type.Equals("AD"))//Top case, Admin should have access to everything that might work
				{
					btnSolve.Enabled = true;
					if (ticket[8].Equals("Unassigned"))
					{
						btnAssign.Enabled = true;
						btnReAssign.Enabled = false;
					}
					else
					{
						btnReAssign.Enabled = true;
						btnAssign.Enabled = false;
					}
				}

				else if (User.current.type.Equals("RM"))// Next Case, Report Manager should only be able to assign or reassign tickets
				{
					if (ticket[8].Equals("Unassigned"))
					{
						btnAssign.Enabled = true;
						btnReAssign.Enabled = false;
					}
					else
					{
						btnReAssign.Enabled = true;
						btnAssign.Enabled = false;
					}
				}

				else if (!ticket[8].Equals("Unassigned")) // Other wise just check if the Ticket is assigned to anyone
				{
					if (ticket[8].Equals(User.current.id.ToString()))// If its the ticket you are assigned to, you should be able to solve and reassign it
					{
						btnSolve.Enabled = true;
						// Solutiontxt.ReadOnly = false;
						btnAssign.Enabled = false;
						btnReAssign.Enabled = true;
					}
				}
				else//Otherwise, if you aren't an Admin, Report Manager, or assigned to the ticket, you can't do anything.
				{
					btnSolve.Enabled = false;
					Solutiontxt.ReadOnly = true;
					btnAssign.Enabled = false;
					btnReAssign.Enabled = true;
				}
				if (selected.dateSolved == DateTime.MinValue)
				{
					btnReopen.Enabled = false;
                    btnSolve.Enabled = true;
				}
				else
				{
					btnReopen.Enabled = true;
                    btnSolve.Enabled = false;
				}

                if (User.current.type.Equals("PM"))
                {
                    btnReopen.Enabled = false;
                    btnSolve.Enabled = false;
                    btnAssign.Enabled = false;
                    btnReAssign.Enabled = false;
                }

            }
		}

	//Button functions
		private void btnResetTable_Click(object sender, EventArgs e)
        {
            TicketList.Items.Clear();
            if (User.current.type.Equals("PM"))
            {
                FilterMyTickets_Click("", new EventArgs());
            } else
            {
                populateTableNoFilter();
            }
        }
        
        private void btnAssignedTicketUser_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = Convert.ToInt32(AssignedUserIDtxt.Text);

                TicketList.Items.Clear();

                List<Ticket> allTickets = Ticket.GetAll();
                List<Ticket> assignedTickets = new List<Ticket>();

                foreach (var ticket in allTickets)
                {
                    if (ticket.assigned != null && ticket.assigned.id == userID)
                    {
                        assignedTickets.Add(ticket);
                        string[] ticketStrings = ticket.toStringArray();
                        ListViewItem item = new ListViewItem(ticketStrings);
                        TicketList.Items.Add(item);
                    }
                }
                tickets = assignedTickets;
            }
            catch
            {
                MessageBox.Show("Invalid user ID.");
                AssignedUserIDtxt.Text = "";
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket edited = getDetailsTicket();
                if (edited != null)
                {
                    edited.Save();
                    // Replace the selected ticket with this new edited ticket
                    int index = TicketList.SelectedIndices[0];
                    tickets[index] = edited;
                    TicketList.Items[index] = new ListViewItem(edited.toStringArray());
                }
            }
            catch
            {
                MessageBox.Show("Please select ticket.");
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var pgAssignTickets = new pgAssignTickets();
            if (pgAssignTickets.ShowDialog() == DialogResult.OK)
            {
                AssignedTotxt.Text = User.workaround.email;
            }
        }

		private void btnReAssign_Click(object sender, EventArgs e)
		{
			var pgAssignTickets = new pgAssignTickets();
			if (pgAssignTickets.ShowDialog() == DialogResult.OK)
			{
				AssignedTotxt.Text = User.workaround.email;
			}
		}

		private void btnSolve_Click(object sender, EventArgs e)
		{
			var pgSolveTicket = new pgSolveTicket();
			if (pgSolveTicket.ShowDialog() == DialogResult.OK)
			{
				if(AssignedTotxt.Text.Equals("Unassigned"))
					AssignedTotxt.Text = User.current.email;

				Solutiontxt.Text = Solutionclass.solvedTicketinfo.solution;
                DateSolvedtxt.Text = Solutionclass.solvedTicketinfo.dateSolved.ToString();

				Ticket solvedTicket = getDetailsTicket();
                solvedTicket.Save();
                TicketList.Items.Clear();
                populateTableNoFilter();
			}
		}

        private void btnReopen_Click(object sender, EventArgs e)
        {
            try
            {
                Solutiontxt.Text += "\n\nTicket Reopened - " + DateTime.Now.ToShortDateString();
                DateSolvedtxt.Text = "Not yet solved";
                Ticket reopenedTicket = getDetailsTicket();
                reopenedTicket.Save();

                TicketList.Items.Clear();
                populateTableNoFilter();
            }
            catch (Exception ex)
            {
				MessageBox.Show(ex.ToString());
            }
        }

	//Filtering Functions
		private void FilterUnsolved_Click(object sender, EventArgs e)
		{
			TicketList.Items.Clear();

			List<Ticket> allTickets = Ticket.GetAll();
			List<Ticket> unsolvedTickets = new List<Ticket>();

			foreach (var ticket in allTickets)
			{
				// If dateSolved is the default value, its unsolved
				if (ticket.dateSolved == DateTime.MinValue)
				{
					unsolvedTickets.Add(ticket);
					string[] ticketStrings = ticket.toStringArray();
					ListViewItem item = new ListViewItem(ticketStrings);
					TicketList.Items.Add(item);
				}
			}
			tickets = unsolvedTickets;
		}

		private void FilterSolved_Click(object sender, EventArgs e)
		{
			TicketList.Items.Clear();

			List<Ticket> allTickets = Ticket.GetAll();
			List<Ticket> solvedTickets = new List<Ticket>();

			foreach (var ticket in allTickets)
			{
				// If dateSolved is not the default value, it has been solved
				if (ticket.dateSolved != DateTime.MinValue)
				{
					solvedTickets.Add(ticket);
					string[] ticketStrings = ticket.toStringArray();
					ListViewItem item = new ListViewItem(ticketStrings);
					TicketList.Items.Add(item);
				}
			}
			tickets = solvedTickets;
		}

		private void FilterMyTickets_Click(object sender, EventArgs e)
		{
			TicketList.Items.Clear();

			List<Ticket> allTickets = Ticket.GetAll();
			List<Ticket> myTickets = new List<Ticket>();

			foreach (var ticket in allTickets)
			{
				// If owner of ticket is the current user, it is my ticket
				if (ticket.owner.id == User.current.id)
				{
					myTickets.Add(ticket);
					string[] ticketStrings = ticket.toStringArray();
					ListViewItem item = new ListViewItem(ticketStrings);
					TicketList.Items.Add(item);
				}
			}
			tickets = myTickets;
		}

		private void FilterAssigned_Click(object sender, EventArgs e)
		{
			TicketList.Items.Clear();

			List<Ticket> allTickets = Ticket.GetAll();
			List<Ticket> assignedTickets = new List<Ticket>();

			foreach (var ticket in allTickets)
			{
				if (ticket.assigned != null)
				{
					assignedTickets.Add(ticket);
					string[] ticketStrings = ticket.toStringArray();
					ListViewItem item = new ListViewItem(ticketStrings);
					TicketList.Items.Add(item);
				}
			}
			tickets = assignedTickets;
		}

		private void FilterAllPriority_Click(object sender, EventArgs e)
		{
			TicketList.Items.Clear();

			List<Ticket> allTickets = Ticket.GetAll();
			List<Ticket> unassignedTickets = new List<Ticket>();

			foreach (var ticket in allTickets)
			{
				if (ticket.assigned == null)
				{
					unassignedTickets.Add(ticket);
					string[] ticketStrings = ticket.toStringArray();
					ListViewItem item = new ListViewItem(ticketStrings);
					TicketList.Items.Add(item);
				}
			}
			tickets = unassignedTickets;
		}

		private void FilterPriority1_Click(object sender, EventArgs e)
		{
			TicketList.Items.Clear();

			List<Ticket> allTickets = Ticket.GetAll();
			List<Ticket> unassignedTickets = new List<Ticket>();

			foreach (var ticket in allTickets)
			{
				if (ticket.assigned == null && ticket.priority == 1)
				{
					unassignedTickets.Add(ticket);
					string[] ticketStrings = ticket.toStringArray();
					ListViewItem item = new ListViewItem(ticketStrings);
					TicketList.Items.Add(item);
				}
			}
			tickets = unassignedTickets;
		}

		private void FilterPriority2_Click(object sender, EventArgs e)
		{
			TicketList.Items.Clear();

			List<Ticket> allTickets = Ticket.GetAll();
			List<Ticket> unassignedTickets = new List<Ticket>();

			foreach (var ticket in allTickets)
			{
				if (ticket.assigned == null && ticket.priority == 2)
				{
					unassignedTickets.Add(ticket);
					string[] ticketStrings = ticket.toStringArray();
					ListViewItem item = new ListViewItem(ticketStrings);
					TicketList.Items.Add(item);
				}
			}
			tickets = unassignedTickets;
		}

		private void FilterPriority3_Click(object sender, EventArgs e)
		{
			TicketList.Items.Clear();

			List<Ticket> allTickets = Ticket.GetAll();
			List<Ticket> unassignedTickets = new List<Ticket>();

			foreach (var ticket in allTickets)
			{
				if (ticket.assigned == null && ticket.priority == 3)
				{
					unassignedTickets.Add(ticket);
					string[] ticketStrings = ticket.toStringArray();
					ListViewItem item = new ListViewItem(ticketStrings);
					TicketList.Items.Add(item);
				}
			}
			tickets = unassignedTickets;
		}

	//Sorting functions
		//Case ID Ascending
		private void Sort_CaseID_Asc(object sender, EventArgs e)
		{
			TicketList.Items.Clear();
			Ticket.sortIDAscending(tickets);
			populateTableSort();
		}
		//Case ID Descending
		private void Sort_CaseID_Desc(object sender, EventArgs e)
		{
			TicketList.Items.Clear();
			Ticket.sortIDDescending(tickets);
			populateTableSort();
		}
		//Owner Ascending
		private void Sort_Owner_Asc(object sender, EventArgs e)
		{
			TicketList.Items.Clear();
			Ticket.sortOwnerAscending(tickets);
			populateTableSort();
		}
		//Owner Descending
		private void Sort_Owner_Desc(object sender, EventArgs e)
		{
			TicketList.Items.Clear();
			Ticket.sortOwnerDescending(tickets);
			populateTableSort();
		}
		//Date Created (most recent to least recent)
		private void Sort_DateCreated_Asc(object sender, EventArgs e)
		{
			TicketList.Items.Clear();
			Ticket.sortDateCreatedAscending(tickets);
			populateTableSort();
		}
		//Date Created (least recent to most recent)
		private void Sort_DateCreated_Desc(object sender, EventArgs e)
		{
			TicketList.Items.Clear();
			Ticket.sortDateCreatedDescending(tickets);
			populateTableSort();
		}
		//Date Solved (most recent to least recent)
		private void Sort_DateSolved_Asc(object sender, EventArgs e)
		{
			TicketList.Items.Clear();
			Ticket.sortDateSolvedAscending(tickets);
			populateTableSort();
		}
		//Date Solved (least recent to most recent)
		private void Sort_DateSolved_Desc(object sender, EventArgs e)
		{
			TicketList.Items.Clear();
			Ticket.sortDateSolvedDescending(tickets);
			populateTableSort();
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var pgAddTicket = new pgAddTicket();
            openForms.Add(pgAddTicket);
            pgAddTicket.Show();
        }

        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {
            var pgRegister = new pgRegister();
            openForms.Add(pgRegister);
            pgRegister.Show();
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            var pgUsers = new pgUsers();
            openForms.Add(pgUsers);
            pgUsers.Show();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var pgReport = new pgReport();
            openForms.Add(pgReport);
            pgReport.Show();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            var pgHelp = new pgHelp();
            openForms.Add(pgHelp);
            pgHelp.Show();
        }

        private void btnfaq_Click(object sender, EventArgs e)
        {
            var pgFAQ = new pgFAQ();
            openForms.Add(pgFAQ);
            pgFAQ.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (Form f in openForms)
                f.Close();
            RefToLogin.Show();
        }
    }
}
