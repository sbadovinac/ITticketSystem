using System;
using System.Windows.Forms;

namespace DBIT
{
    public partial class pgSolveTicket : Form
    {
        
        public pgSolveTicket()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			Solutionclass.solvedTicketinfo = new Solutionclass();
            try
            {
                if (!String.IsNullOrEmpty(txtSolution.Text))
                {
                    Solutionclass.solvedTicketinfo.solution = txtSolution.Text;
                    Solutionclass.solvedTicketinfo.dateSolved = DateTime.Now;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Please enter a non-empty solution. " + er.ToString(), "Error");
                txtSolution.Text = "";
            }
			/*Solutionclass.solvedTicketinfo.solution = txtSolution.Text;
            Solutionclass.solvedTicketinfo.dateSolved = DateTime.Now;
			DialogResult = DialogResult.OK;
			Close();*/
		}
    }
}
