using System;
using System.Windows.Forms;


namespace DBIT
{
    public partial class pgRegister : Form
    {
        public pgRegister()
        {
            InitializeComponent();
        }

        private void btnSubmitNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch data from UI
                string email = txtNewUserEmail.Text;
                string pass = txtNewUserPassword.Text;
                string type = cmbNewUserType.Text;
				if (type.Equals("Admin") || type.Equals("Report Manager") || type.Equals("I.T. Specialist") || type.Equals("Program Member"))
				{
					if (type.Equals("Admin"))
						type = "AD";
					if (type.Equals("Report Manager"))
						type = "RM";
					if (type.Equals("I.T. Specialist"))
						type = "IT";
					if (type.Equals("Program Member"))
						type = "PM";
					User user = new User(email, type);
					bool success = user.Register(pass);

					if (success)
					{
						// User successfully registered
						MessageBox.Show("You have created an account!", "Success");
						if (cbxEmail.Checked == true)
						{
							try
							{
								String emailsubject = "You have created an account with DBIT!";
								String emailbody = "You have succesfully created an account"
													+ "<br/>"
													+ "<b>Username</b>: " + email + "<br/>"
													+ "<b>Password</b>: " + pass + "<br/>"
													+ "<b>User Type</b>: " + type + "<br/>"
													+ "<br/>"
													+ "Thank you, <br/>"
													+ "Dragon Ball IT team";

								Email emailObj = new Email(email, emailsubject, emailbody);
								emailObj.Send();

								MessageBox.Show("Mail Sent!"); // This happens without triggering the catch which is a good sign.

								this.Close();

							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.ToString());
							}
						}
						this.Close();
					}
					else
					{
						MessageBox.Show("Invalid credentials.");
					}
				}
				else
				{
					MessageBox.Show("Please select a valid user type.", "Error");
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error.\n" + ex.ToString());
            }
        }
    }
}
