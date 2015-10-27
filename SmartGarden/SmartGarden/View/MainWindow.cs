
using SmartGarden.Controller;
using SmartGarden.Model;
using SmartGarden.Model.Gestore_Informazioni;
using SmartGarden.Model.Gestore_Informazioni.Fornitori;
using SmartGarden.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.XPath;

namespace SmartGarden.View
{
    partial class MainWindow : System.Windows.Forms.Form
    {
        private IMyController _controller;
        private GestioneGiardino _gestioneGiardino;
        private static MainWindow _instance = null;
        
        private MainWindow()
        {
            InitializeComponent();
            _provinceComboBox.SelectedIndexChanged += CambiaProvincia;
            _gestioneGiardino = GestioneGiardino.GetGestoreGiardino();
        }

        public static MainWindow GetMainWindow()
        {
            if (_instance == null)
            {
                _instance = new MainWindow();
            }
            return _instance;
        }

        public IMyController Controller
        {
            get { return _controller; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _controller =  MyController.GetController(_gestioneGiardino);

            bool loginOk = _controller.CreaLoginForm();
            if (!loginOk)
                this.Close();

            IGiardino giardino = new Giardino();
            _gestioneGiardino.Giardino = giardino;

            AggiornaViews();

            _dateStatusBar.Text = DateTime.Now.ToShortDateString();

            CaricaProvince();

            #region TEST
            
            Dictionary<Type, Type> type = new Dictionary<Type, Type>();
            type.Add(typeof(ProviderPrecipitazioniDefaultHttp), typeof(StandardInformationVisitor));
            IFactoryGestoreInformazioni fac = FactoryGestoreInformazioni.GetFactory();

            _gestioneGiardino.Luogo = "Modena";
            ICisterna cisterna = new Cisterna(20, 30);
            _gestioneGiardino.Giardino.Cisterna = cisterna;
            ISettore settore = new Settore("Settore nord", 200);
            ISettore settore2 = new Settore("Settore sud", 100);
            ValvolaDiSettore valv = new ValvolaDiSettore();
            valv.Name = "mario";
            ValvolaDiSettore valv2 = new ValvolaDiSettore();
            valv.Name = "ugo";
            settore.ValvolaSettore = valv;
            settore2.ValvolaSettore = valv2;
            IPianta pianta1 = new Pianta("Solanum lycopersicum", "Pomodoro", 0.50);
            FabbisognoGiornalieroPeriodo fabb1 = new FabbisognoGiornalieroPeriodo(DateTime.Now, DateTime.Now.AddYears(1), 50);
            pianta1.AddFabisogno(fabb1);
            pianta1.GestoreInformazioni = fac.GetGestore(type);
            IPianta pianta2 = new Pianta("Lactuca sativa", "Lattuga", 0.30);
            FabbisognoGiornalieroPeriodo fabb23 = new FabbisognoGiornalieroPeriodo(DateTime.Now, DateTime.Now.AddYears(1), 100);
            pianta2.AddFabisogno(fabb23);
            pianta2.GestoreInformazioni = fac.GetGestore(type);
            IPianta pianta3 = new Pianta("Ocimum basilicum", "Basilico", 0.40);
            pianta3.AddFabisogno(fabb23);
            pianta3.GestoreInformazioni = fac.GetGestore(type);
            settore.AddPianta(pianta1);
            settore.AddPianta(pianta2);
            settore2.AddPianta(pianta3);
            _gestioneGiardino.Giardino.AddSettore(settore);
            _gestioneGiardino.Giardino.AddSettore(settore2);
            
            #endregion


        }

        public GestioneGiardino GestioneGiardino
        {
            get { return _gestioneGiardino; }
            set
            {
                _gestioneGiardino = GestioneGiardino;
                AggiornaViews();
            }
        }

        private void AggiornaViews()
        {
            _pannelloDestra.GestoreGiardino = GestioneGiardino; //set del model
            _pannelloDestra.Controller = _controller; //set del controller
            _treeView.GestoreGiardino = GestioneGiardino;
            _treeView.Controller = _controller;
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
            _controller.CreaSettoriView();
        }

        private void _pannelloDestra_Load(object sender, EventArgs e)
        {
            //
        }

        private void visualizzaNotificheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.CreaNotificheView();
        }

        private void modificaTimerGeneraleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.GestisciTimer();
        }
    }
}
