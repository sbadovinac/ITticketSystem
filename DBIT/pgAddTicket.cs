using System;
using System.Windows.Forms;

namespace DBIT
{
    public partial class pgAddTicket : Form
    {
        public pgAddTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e)
        {
            try
            {

                // Fetch data from GUI
                string header = txtHeader.Text;
                string description = txtDescription.Text;
				if (!String.IsNullOrEmpty(txtHeader.Text) && !String.IsNullOrEmpty(txtDescription.Text))
				{
					DateTime myDateTime = DateTime.Now;
					string datecreated = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

					string solution = "No Solution";

					Ticket tobeaddedTicket = new Ticket(0, header, description, myDateTime, myDateTime, myDateTime, false, 0, User.current, null, solution);

					tobeaddedTicket.Save();

					MessageBox.Show("Your ticket has been added!", "Success");
					try
					{
						String emailsubject = "You have created a ticket!";
						String emailbody = "You have succesfully added a ticket to the Dragon Ball IT ticketing system!<br/>"
											+ "<br/>"
											+ "<b>Header</b>: " + header + "<br/>"
											+ "<b>Description</b>: " + description + "<br/>"
											+ "<br/>"
											+ "Thank you, <br/>"
											+ "Dragon Ball IT team";

						Email email = new Email(User.current.email, emailsubject, emailbody);
						email.Send();

						this.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
				}
				else
				{
					MessageBox.Show("Please enter the issue and describe the issue.", "Error");
				}
			}
            catch (Exception er)
            {
                MessageBox.Show("There was a problem adding your ticket. " + er.ToString(), "Error");
                txtHeader.Text = "";
                txtDescription.Text = "";
            }
        }

        // If user selects something from the common problems box, populate txtHeader with their choice
        private void cbxCommon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHeader.Text = cbxCommon.Text;
        }
    }
}
