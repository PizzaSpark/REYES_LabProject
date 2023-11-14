using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REYES_LabProject
{
    internal static class Program
    {
        private static int openFormCount = 1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login Login = new Login();
            Login.FormClosed += Form_FormClosed;
            Login.Show();

            Application.Run();
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            openFormCount--;
            if (openFormCount == 0)
            {
                Application.Exit(); // Exit the application when all forms are closed
            }
        }

        public static void OpenNewForm(Form latest)
        {
            latest.FormClosed += Form_FormClosed;
            latest.Show();
            openFormCount++; // Increment the count when a new form is shown
        }
    }
}
