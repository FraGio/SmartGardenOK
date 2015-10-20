using SmartGarden.View;
using System.Windows.Forms;
using System.Xml.XPath;
using SmartGarden.Model;
using System;

namespace SmartGarden.Control
{
    class Controller : IController
    {
        private readonly GestioneGiardino _gestioneGiardino; //GestioneGiardino è il model

        public Controller(GestioneGiardino gestioneGiardino)
        {
            _gestioneGiardino = gestioneGiardino;
        }

        public bool CreateLoginForm()
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

        public void CaricaViewPiante(string nomeSettore)
        {

            Settore settore = _gestioneGiardino.Giardino.Settori.TrovaSettore(nomeSettore);

            using (var pianteForm = new Form())
            {
                PianteView pianteView = new PianteView(settore);
                pianteView.Dock = DockStyle.Fill;
                pianteForm.Text = "Piante di " + settore.Nome;
                pianteForm.Size = new System.Drawing.Size(1000,400);
                pianteForm.Controls.Add(pianteView);
                pianteForm.ShowDialog();
            }
        }

        public void CambiaProvincia(string provincia)
        {
            _gestioneGiardino.Giardino.Luogo = provincia;
            _gestioneGiardino.AggiornaInfoMeteo();
        }

        public void CaricaProvinceComboBox(ComboBox provinceComboBox)
        {
            XPathDocument doc = new XPathDocument("ProvinceItaliane.xml");
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr = nav.Compile("./italia/provincia");
            XPathNodeIterator iterator = nav.Select(expr);


            while (iterator.MoveNext())
            {
                provinceComboBox.Items.Add(iterator.Current.Value);
            }
        }

        public void CaricaInfoGiardino()
        {
            //_gestioneGiardino.ProvaCaricamentoInfo();
        }

        public void SettaTimer()
        {
            //_gestioneGiardino.SettaTimer();
        }

        public void GestisciSettori()
        {
            using (var settoriForm = new Form())
            {
                _settoriView settoriView = new _settoriView();
                settoriView.GestoreGiardino = _gestioneGiardino;
                settoriView.Controller = this;
                settoriView.Dock = DockStyle.Fill;
                settoriForm.Text = "Gestione settori";
                settoriForm.Size = new System.Drawing.Size(600, 300);
                settoriForm.Controls.Add(settoriView);
                settoriForm.ShowDialog();
            }
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
                    nuovoGiardinoForm.Text = "Nuovo giardino";
                    nuovoGiardinoForm.Size = new System.Drawing.Size(380, 170);
                    nuovoGiardinoForm.Controls.Add(nuovoGiardinoView);

                    var result2 = nuovoGiardinoForm.ShowDialog();

                    if (result2 == DialogResult.OK)
                    {
                        _gestioneGiardino.ResetGiardino();
                        _gestioneGiardino.Giardino.Luogo = nuovoGiardinoView.Controls.Find("_provinceComboBox", false)[0].Text;
                        _gestioneGiardino.AggiornaInfoMeteo();
                    }
                }
            }
        }

        public void CreaPiantaView(IPianta pianta)
        {
            using (var piantaForm = new Form())
            {
                PiantaView piantaView = new PiantaView(pianta);
                piantaView.GestoreGiardino = _gestioneGiardino;
                piantaView.Controller = this;
                piantaView.Dock = DockStyle.Fill;
                piantaForm.Text = "Gestione info pianta";
                piantaForm.Size = new System.Drawing.Size(600, 300);
                piantaForm.Controls.Add(piantaView);
                piantaForm.ShowDialog();
            }
        }
    }
}
