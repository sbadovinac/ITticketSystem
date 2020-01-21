using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBIT
{
    public partial class pgAssignTickets : Form
    {

        List<User> users;

        public pgAssignTickets()
        {
            InitializeComponent();
            populateTableNoFilter();
        }

        private void populateTableNoFilter()
        {
            users = User.GetAll();
            List<User> notPMusers = new List<User>();
            foreach (var user in users)
            {
                if (user.type != "PM")
                {
                    string[] userStrings = user.toStringArray();
                    ListViewItem item = new ListViewItem(userStrings);
                    lstUsers.Items.Add(item);
                    notPMusers.Add(user);
                }
            }
            users = notPMusers;
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstUsers.SelectedIndices[0];
            User.workaround = users[index];
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
