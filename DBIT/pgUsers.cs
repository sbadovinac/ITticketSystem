using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBIT
{
    public partial class pgUsers : Form
    {

        List<User> users;

        public pgUsers()
        {
            InitializeComponent();
            populateTableNoFilter();

            // Hide edit user type button for everyone but Admins
            switch (User.current.type)
            {
                case "IT":
                    btnEditUserType.Visible = false;
                    cbxType.Visible = false;
                    break;
                case "RM":
                    btnEditUserType.Visible = false;
                    cbxType.Visible = false;
                    break;
                default:
                    txtType.Visible = false;
                    break;
            }
        }

        private void resetTable()
        {
            UserList.Items.Clear();
            populateTableNoFilter();
        }

        private void populateTableNoFilter()
        {
            users = User.GetAll();
            foreach (var user in users)
            {
                string[] userStrings = user.toStringArray();
                ListViewItem item = new ListViewItem(userStrings);
                UserList.Items.Add(item);
            }
        }

		private void populateTableSort(int Identifier)
		{
			users = User.GetAllSorted(Identifier);
			// Traverse ticket list and display into the table view
			foreach (var user in users)
			{
				string[] userStrings = user.toStringArray();
				ListViewItem item = new ListViewItem(userStrings);
				UserList.Items.Add(item);
			}
		}

		private void populateDetails()
        {
            User selected = getSelectedUser();
            if (selected != null)
            {
                string[] str = selected.toStringArray();
                txtUserID.Text = str[0];
                txtEmail.Text = str[1];
                txtType.Text = str[2];
                txtDateCreated.Text = str[3];
                cbxType.Text = str[2];
            }
        }

        private User getSelectedUser()
        {
            if (UserList.SelectedItems.Count == 0) return null;
            int index = UserList.SelectedIndices[0];
            return users[index];
        }

        // Event Handlers

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateDetails();
        }

        private void FilterAD_Click(object sender, EventArgs e)
        {
            UserList.Items.Clear();

            List<User> allUsers = User.GetAll();
            List<User> adminUsers = new List<User>();

            foreach (var user in allUsers)
            {
                // If dateSolved is the default value, its unsolved
                if (user.type == "AD")
                {
                    adminUsers.Add(user);
                    string[] ticketStrings = user.toStringArray();
                    ListViewItem item = new ListViewItem(ticketStrings);
                    UserList.Items.Add(item);
                }
            }
            users = adminUsers;
        }

        private void FilterIT_Click(object sender, EventArgs e)
        {
            UserList.Items.Clear();

            List<User> allUsers = User.GetAll();
            List<User> itUsers = new List<User>();

            foreach (var user in allUsers)
            {
                // If dateSolved is the default value, its unsolved
                if (user.type == "IT")
                {
                    itUsers.Add(user);
                    string[] ticketStrings = user.toStringArray();
                    ListViewItem item = new ListViewItem(ticketStrings);
                    UserList.Items.Add(item);
                }
            }
            users = itUsers;
        }

        private void FilterPM_Click(object sender, EventArgs e)
        {
            UserList.Items.Clear();

            List<User> allUsers = User.GetAll();
            List<User> pmUsers = new List<User>();

            foreach (var user in allUsers)
            {
                // If dateSolved is the default value, its unsolved
                if (user.type == "PM")
                {
                    pmUsers.Add(user);
                    string[] ticketStrings = user.toStringArray();
                    ListViewItem item = new ListViewItem(ticketStrings);
                    UserList.Items.Add(item);
                }
            }
            users = pmUsers;
        }

        private void FilterRM_Click(object sender, EventArgs e)
        {
            UserList.Items.Clear();

            List<User> allUsers = User.GetAll();
            List<User> rmUsers = new List<User>();

            foreach (var user in allUsers)
            {
                // If dateSolved is the default value, its unsolved
                if (user.type == "RM")
                {
                    rmUsers.Add(user);
                    string[] ticketStrings = user.toStringArray();
                    ListViewItem item = new ListViewItem(ticketStrings);
                    UserList.Items.Add(item);
                }
            }
            users = rmUsers;
        }

		//ID Ascending
		private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserList.Items.Clear();
			populateTableSort(1);
		}
		//ID Descending
		private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserList.Items.Clear();
			populateTableSort(2);
		}
		//Date created Recent
		private void recentFirstToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserList.Items.Clear();
			populateTableSort(3);
		}
		//Date created old
		private void recentLastToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserList.Items.Clear();
			populateTableSort(4);
		}

        private void btnEditUserType_Click(object sender, EventArgs e)
        {
            // Fetch data from GUI
            try
            {
                int id;
                int.TryParse(txtUserID.Text, out id);
                string email = txtEmail.Text;
                string type = cbxType.Text;
                if (type == "Admin")
                    type = "AD";
                if (type == "Report Manager")
                    type = "RM";
                if (type == "I.T. Specialist")
                    type = "IT";
                if (type == "Program Member")
                    type = "PM";

                User user = new User(id, email, type, DateTime.Now);
                user.EditUserType(type, id);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error.\n" + ex.ToString());
            }

        }
    }
}
