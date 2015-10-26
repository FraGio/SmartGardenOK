using SmartGarden.View;
using System.Windows.Forms;
using System.Xml.XPath;
using SmartGarden.Model;
using SmartGarden.Controller;
using System.Drawing;
using System;

namespace SmartGarden.Controller
{
    class MyController : IMyController
    {
        private readonly GestioneGiardino _gestioneGiardino; //GestioneGiardino è il model
        private static MyController _instance = null;

        private MyController(GestioneGiardino gestioneGiardino)
        {
            _gestioneGiardino = gestioneGiardino;
        }

        public static MyController GetController(GestioneGiardino gestioneGiardino)
        {
            if (_instance == null)
                _instance = new MyController(gestioneGiardino);
            return _instance;
        }

        public bool CreaLoginForm()
        {
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void CreaPianteView(string nomeSettore, Form settoriForm)
        {

            if (settoriForm != null)
            {
                settoriForm.Dispose();
            }

            ISettore settore = _gestioneGiardino.Giardino.GetSettore(nomeSettore);

            using (var pianteForm = new Form())
            {
                PianteView pianteView = new PianteView(settore);
                pianteView.Dock = DockStyle.Fill;
                CustomizeForm(pianteForm, "Piante di " + settore.Nome, new System.Drawing.Size(1000, 400), pianteView);

                var result = pianteForm.ShowDialog();
                if (result == DialogResult.Cancel)
                    CreaSettoriView();
            }
        }

        public void CambiaProvincia(string provincia)
        {
            _gestioneGiardino.Luogo = provincia;
            //_gestioneGiardino.AggiornaInfoMeteo();
        }

        public void CaricaProvinceComboBox(ComboBox provinceComboBox)
        {
            XPathDocument doc = new XPathDocument("ProvinceItaliane.xml" );
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr = nav.Compile("./italia/provincia");
            XPathNodeIterator iterator = nav.Select(expr);


            while (iterator.MoveNext())
            {
                provinceComboBox.Items.Add(iterator.Current.Value);
            }
        }

        public void CreaSettoriView()
        {
            using (var settoriForm = new Form())
            {
                SettoriView settoriView = new SettoriView();
                settoriView.GestoreGiardino = _gestioneGiardino;
                settoriView.Controller = this;
                settoriView.Dock = DockStyle.Fill;
                CustomizeForm(settoriForm, "Gestione settori", new System.Drawing.Size(900, 300), settoriView);

                var result = settoriForm.ShowDialog();

                if(result == DialogResult.OK)
                {
                    CreaNuovoSettoreView();
                }
            }
        }

        private void CreaNuovoSettoreView()
        {
            using (var nuovoSettoreForm = new Form())
            {
                NuovoSettoreView nuovoSettView = new NuovoSettoreView();
                nuovoSettView.GestoreGiardino = _gestioneGiardino;
                nuovoSettView.Controller = this;
                nuovoSettView.Dock = DockStyle.Fill;
                CustomizeForm(nuovoSettoreForm, "Nuovo settore", new System.Drawing.Size(350, 220), nuovoSettView);

                var result = nuovoSettoreForm.ShowDialog();
            }
        }

        public void CreaSettoreView(string nomeSettore, double portataImpianto, Valvola valvola)
        {
            ISettore settore = new Settore(nomeSettore, portataImpianto);
            settore.ValvolaSettore = valvola;
            if (!_gestioneGiardino.Giardino.AddSettore(settore))
            {
                MessageBox.Show("Settore già esistente!");
            }
        }

        public void CancellaSettore(string nomeSettore)
        {
            _gestioneGiardino.Giardino.RemoveSettore(nomeSettore);
        }

        public void NuovoGiardino()
        {

            var result1 = MessageBox.Show("Questa operazione cancellerà il tuo giardino corrente.\r\nSei sicuro di voler procedere?", "Avviso", MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                using (var nuovoGiardinoForm = new Form())
                {
                    NuovoGiardinoView nuovoGiardinoView = new NuovoGiardinoView();
                    nuovoGiardinoView.Dock = DockStyle.Fill;
                    CustomizeForm(nuovoGiardinoForm, "Nuovo giardino", new System.Drawing.Size(380, 170), nuovoGiardinoView);

                    var result2 = nuovoGiardinoForm.ShowDialog();

                    if (result2 == DialogResult.OK)
                    {
                        _gestioneGiardino.Giardino.Delete();
                        Giardino giardino = new Giardino();
                        _gestioneGiardino.Giardino = giardino;
                        _gestioneGiardino.Luogo = nuovoGiardinoView.Controls.Find("_provinceComboBox", false)[0].Text;
                        MainWindow mainWindow = MainWindow.GetMainWindow();
                        mainWindow.GestioneGiardino = _gestioneGiardino;
                       // _gestioneGiardino.AggiornaInfoMeteo();
                    }
                }
            }
        }

        public void CreaGestioneInfoPiantaView(IPianta pianta)
        {
            using (var piantaForm = new Form())
            {
                PiantaView piantaView = new PiantaView(pianta);
                piantaView.GestoreGiardino = _gestioneGiardino;
                piantaView.Controller = this;
                piantaView.Dock = DockStyle.Fill;

                CustomizeForm(piantaForm, "Gestione info pianta", new System.Drawing.Size(600, 300), piantaView);

                piantaForm.ShowDialog();
            }
        }

        public void GestisciTimer()
        {
            using (var timerForm = new Form())
            {
                GestoreTimerView timerView = new GestoreTimerView();
                timerView.GestoreGiardino = _gestioneGiardino;
                timerView.Controller = this;
                timerView.Dock = DockStyle.Fill;
                CustomizeForm(timerForm, "Gestione timer", new System.Drawing.Size(500, 400), timerView);

                timerForm.ShowDialog();
            }
        }

        public void CreaGestisciCisternaView()
        {
            using (var cisternaForm = new Form())
            {
                GestisciCisternaView cisternaView = new GestisciCisternaView();
                cisternaView.GestoreGiardino = _gestioneGiardino;
                cisternaView.Controller = this;
                cisternaView.Dock = DockStyle.Fill;

                CustomizeForm(cisternaForm, "Gestione cisterna", new System.Drawing.Size(600, 300), cisternaView);
                cisternaForm.ShowDialog();
            }
        }

        public void CreaNuovaCisterna(double portata, double capacità)
        {
            ICisterna cisterna = new Cisterna(portata, capacità);
            _gestioneGiardino.Giardino.Cisterna = cisterna;
        }

        public void CreaNuovaPianta(string nomeBotanico, string nomeComune, double area, string nomeSettore, FabbisognoGiornalieroPeriodo fabbisognoPeriodo)
        {
            IPianta pianta = new Pianta(nomeBotanico, nomeComune, area);
            ISettore settore = _gestioneGiardino.Giardino.GetSettore(nomeSettore);
            pianta.AddFabisogno(fabbisognoPeriodo);
            settore.AddPianta(pianta);
        }

        public void CancellaPianta(IPianta pianta, ISettore settore)
        {
            settore.RemovePianta(pianta);
        }

        public void CreaAggiungiPiantaView(string nomeSettore, Form parentForm)
        {

            if (parentForm != null)
                parentForm.Dispose();

            using (var piantaForm = new Form())
            {
                NuovaPiantaView nuovaPiantaView = new NuovaPiantaView(nomeSettore);
                nuovaPiantaView.Dock = DockStyle.Fill;
                CustomizeForm(piantaForm, "Nuova pianta", new System.Drawing.Size(450, 550), nuovaPiantaView);

                var result = piantaForm.ShowDialog();
            }

            CreaPianteView(nomeSettore, null);
        }

        public void CreaNotificheView()
        {
            using (var notificheForm = new Form())
            {
                NotificheView notificheView = new NotificheView();
                notificheView.Dock = DockStyle.Fill;
                CustomizeForm(notificheForm, "Notifiche", new System.Drawing.Size(500, 400), notificheView);

                var result = notificheForm.ShowDialog();
            }
        }

        public void CreaGestoreFabbisognoPiantaView(IPianta pianta)
        {
            using (var fabbisognoForm = new Form())
            {
                GestisciFabbisognoPiantaView fabbView = new GestisciFabbisognoPiantaView(pianta);
                fabbView.Dock = DockStyle.Fill;
                CustomizeForm(fabbisognoForm, "Fabbisogni di: [" + pianta.NomeBotanico + ", " + pianta.NomeComune + "]",
                    new System.Drawing.Size(500, 400), fabbView);

                var result = fabbisognoForm.ShowDialog();
            }
        }

        public void CreaMeteoView()
        {
            using (var meteoForm = new Form())
            {
                MeteoView meteoView = new MeteoView();
                meteoView.Dock = DockStyle.Fill;

                CustomizeForm(meteoForm, "Meteo tra 24h", new System.Drawing.Size(530, 320), meteoView);

                var result = meteoForm.ShowDialog();
            }
        }

        private void CustomizeForm(Form form, string titolo, Size size, MainView view)
        {
            form.Icon = Properties.Resources.Logo;
            form.Text = titolo;
            form.Size = size;
            form.Controls.Add(view);
        }

        public void SettaTimer(DateTime inizio, TimeSpan intervallo)
        {
            _gestioneGiardino.SetTimer(inizio, intervallo);
        }
    }
}
