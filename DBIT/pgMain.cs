using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBIT
{
    public partial class pgMain : Form
    {
        public Form RefToLogin { get; set; }
        public List<Form> openForms { get; set; }

        public pgMain()
        {
            InitializeComponent();
            openForms = new List<Form>();

            // Hide buttons that aren't allowed for a particular user type
            switch (User.current.type)
            {
                case "PM":
                    btnUsers.Visible = false;
                    btnRegister.Visible = false;
                    btnReport.Visible = false;
                    break;
                case "IT":
                    btnRegister.Visible = false;
                    btnReport.Visible = false;
                    break;
                case "RM":
                    btnAddTicket.Visible = false;
                    btnRegister.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            var pgAddTicket = new pgAddTicket();
            openForms.Add(pgAddTicket);
            pgAddTicket.Show();
        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            var pgTickets = new pgTickets();
            openForms.Add(pgTickets);
            pgTickets.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var pgRegister = new pgRegister();
            openForms.Add(pgRegister);
            pgRegister.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var pgUsers = new pgUsers();
            openForms.Add(pgUsers);
            pgUsers.Show();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            var pgFAQ = new pgFAQ();
            openForms.Add(pgFAQ);
            pgFAQ.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            var pgHelp = new pgHelp();
            openForms.Add(pgHelp);
            pgHelp.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var pgReport = new pgReport();
            openForms.Add(pgReport);
            pgReport.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (Form f in openForms)
                f.Close();
            RefToLogin.Show();
        }
    }
}
