using SmartGarden.Model;
using SmartGarden.View;
using System;
using System.Windows.Forms;

namespace SmartGarden
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

            Application.Run(MainWindow.GetMainWindow());

        }
    }
}
