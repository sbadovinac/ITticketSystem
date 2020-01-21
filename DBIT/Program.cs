using System;
using System.Windows.Forms;

namespace DBIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var login = new pgLogin();
            login.Show();
            Application.Run();
        }
    }
}
