using SmartGarden.Model;
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

            #region TEST

            GestioneGiardino gestioneGiardino = GestioneGiardino.GetGestoreGiardino();

            #endregion

            Application.Run(new MainWindow());
        }
    }
}
