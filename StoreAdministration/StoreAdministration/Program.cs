using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace StoreAdministration
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Trace.WriteLine("Application started.");
            Application.Run(new LogInForm());
            Trace.WriteLine("Application ended.");
        }
    }
}
