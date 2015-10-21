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
            gestioneGiardino.Giardino = new Giardino();
            ISettore settore = new Settore("Settore nord", 200);
            ISettore settore2 = new Settore("Settore sud", 100);
            IPianta pianta1 = new Pianta("Byuisl", "Pomodoro", 0.50);
            IPianta pianta2 = new Pianta("Nmdsa", "Lattuga", 0.30);
            IPianta pianta3 = new Pianta("Ghh", "Geranio", 0.40);
            settore.AddPianta(pianta1);
            settore.AddPianta(pianta2);
            settore2.AddPianta(pianta3);
            gestioneGiardino.Giardino.AddSettore(settore);
            gestioneGiardino.Giardino.AddSettore(settore2);

            #endregion

            Application.Run(new MainWindow());
        }
    }
}
