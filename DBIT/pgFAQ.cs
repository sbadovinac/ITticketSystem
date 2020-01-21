using System.Windows.Forms;

namespace DBIT
{
    public partial class pgFAQ : Form
    {
        public pgFAQ()
        {
            InitializeComponent();
            try
            {
                faqWebBrowser.Navigate("https://blue.butler.edu/~gforsyth/SE361/FAQ.html");
            }
            catch
            {
                MessageBox.Show("There was an error loading the page. Try again later!");
            }
        }
    }
}
