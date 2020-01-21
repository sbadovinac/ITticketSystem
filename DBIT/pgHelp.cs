using System;
using System.Windows.Forms;

namespace DBIT
{
    public partial class pgHelp : Form
    {
        public pgHelp()
        {
            InitializeComponent();
            try
            {
                if (User.current.type == "RM")   //this will select the website that will be navigated to based on user type
                    helpWebBrowser.Navigate("https://blue.butler.edu/~gforsyth/SE361/HelpRM.html");
                else if (User.current.type == "PM")
                    helpWebBrowser.Navigate("https://blue.butler.edu/~gforsyth/SE361/HelpPM.html");
                else if (User.current.type == "IT")
                    helpWebBrowser.Navigate("https://blue.butler.edu/~gforsyth/SE361/HelpIT.html");
                else
                    helpWebBrowser.Navigate("https://blue.butler.edu/~gforsyth/SE361/HelpAD.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
