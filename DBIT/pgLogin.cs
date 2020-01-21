using System;
using System.Windows.Forms;

namespace DBIT
{
    public partial class pgLogin : Form
    {
       

        public pgLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Fetch data from GUI
                string Email = txtUsername.Text;
                string Password = txtPassword.Text;

                // Get user from database
                User requestedUser = User.Get(Email, Password);

                if (requestedUser != null)
                {

                    // Update who the current logged in user is
                    User.current = requestedUser;

                    // Load main page
                    var main = new pgTickets();
                    main.RefToLogin = this;
                    main.Show();
                    this.Hide();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
                else
                {
                    // Login credentials are incorrect
                    MessageBox.Show("Incorrect Username or Password", "Please try again.");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("There was an error." + er.ToString(), "Error");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var OpenRegister = new pgRegister();
            OpenRegister.Show();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "admin@test.com";
            txtPassword.Text = "test";
            btnLogin_Click(sender, e);
        }
    }
}
