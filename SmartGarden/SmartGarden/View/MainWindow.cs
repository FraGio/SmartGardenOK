
using SmartGarden.Control;
using SmartGarden.Model;
using SmartGarden.Model.Gestore_Informazioni;
using SmartGarden.Model.Gestore_Informazioni.Fornitori;
using SmartGarden.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.XPath;

namespace SmartGarden
{
    partial class MainWindow : Form
    {
        private Controller _controller;

        public MainWindow()
        {
            InitializeComponent();
            _provinceComboBox.SelectedIndexChanged += CambiaProvincia;
        }

        public Controller Controller
        {
            get { return _controller; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GestioneGiardino gestoreGiardino = GestioneGiardino.GetGestoreGiardino();
            _controller = new Controller(gestoreGiardino);

            bool loginOk = _controller.CreateLoginForm();
            if (!loginOk)
                this.Close();
            
            _pannelloDestra.GestoreGiardino = gestoreGiardino; //set del model
            _pannelloDestra.Controller = _controller; //set del controller
            _treeView.GestoreGiardino = gestoreGiardino;
            _treeView.Controller = _controller;
            

            _dateStatusBar.Text = DateTime.Now.ToShortDateString();

            _controller.SettaTimer();

            _controller.CaricaInfoGiardino();

            CaricaProvince();

            #region TEST

            gestoreGiardino.Giardino = new Giardino();
            Dictionary<Type, Type> type = new Dictionary<Type, Type>();
            type.Add(typeof(ProviderPrecipitazioniDefaultHttp), typeof(StandardInformationVisitor));
            IFactoryGestoreInformazioni fac = FactoryGestoreInformazioni.GetFactory();

            ISettore settore = new Settore("Settore nord", 200);
            ISettore settore2 = new Settore("Settore sud", 100);
            IPianta pianta1 = new Pianta("Byuisl", "Pomodoro", 0.50);
            FabbisognoGiornalieroPeriodo fabb1 = new FabbisognoGiornalieroPeriodo(DateTime.Now, DateTime.Now.AddYears(1), 50);
            pianta1.AddFabisogno(fabb1);
            pianta1.GestoreInformazioni = fac.GetGestore(type);
            IPianta pianta2 = new Pianta("Nmdsa", "Lattuga", 0.30);
            FabbisognoGiornalieroPeriodo fabb23 = new FabbisognoGiornalieroPeriodo(DateTime.Now, DateTime.Now.AddYears(1), 100);
            pianta2.AddFabisogno(fabb23);
            pianta2.GestoreInformazioni = fac.GetGestore(type);
            IPianta pianta3 = new Pianta("Ghh", "Geranio", 0.40);
            pianta3.AddFabisogno(fabb23);
            pianta3.GestoreInformazioni = fac.GetGestore(type);
            settore.AddPianta(pianta1);
            settore.AddPianta(pianta2);
            settore2.AddPianta(pianta3);
            gestoreGiardino.Giardino.AddSettore(settore);
            gestoreGiardino.Giardino.AddSettore(settore2);
            
            #endregion


        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        private void CaricaProvince()
        {
            _controller.CaricaProvinceComboBox(_provinceComboBox.ComboBox);
        }


        private void CambiaProvincia(object sender, EventArgs e)
        {
            _controller.CambiaProvincia(_provinceComboBox.SelectedItem.ToString());
        }

        private void _resetToolStrip_Click(object sender, EventArgs e)
        {
            Controller.NuovoGiardino();
        }

        private void gestisciGiardinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.GestisciSettori();
        }

        private void _pannelloDestra_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
