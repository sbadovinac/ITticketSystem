using System.Windows.Forms;

namespace DBIT
{
    public partial class pgReport : Form
    {
        public pgReport()
        {
            InitializeComponent();
            Report rep = new Report();

            lblTotalTickets.Text = rep.numTickets + "";
            lblTotalAssigned.Text = rep.numAssigned + "";
            lblTotalUnassigned.Text = rep.numUnassigned + "";
            lblTotalSolved.Text = rep.numSolved + "";
            lblTotalUnsolved.Text = rep.numUnsolved + "";

            lblTotalUsers.Text = rep.numUsers + "";
            lblTotalPM.Text = rep.numPM + "";
            lblTotalIT.Text = rep.numIT + "";
            lblTotalRM.Text = rep.numRM + "";
            lblTotalAD.Text = rep.numAD + "";
        }
    }
}
