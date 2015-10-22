﻿using SmartGarden.View;
using System.Windows.Forms;
using System.Xml.XPath;
using SmartGarden.Model;
using System;

namespace SmartGarden.Control
{
    class MyController : IController
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
            ISettore settore = _gestioneGiardino.Giardino.GetSettore(nomeSettore);

            using (var pianteForm = new Form())
            {
                PianteView pianteView = new PianteView(settore);
                pianteView.Dock = DockStyle.Fill;
                pianteForm.Text = "Piante di " + settore.Nome;
                pianteForm.Size = new System.Drawing.Size(900,400);
                pianteForm.Controls.Add(pianteView);
                pianteForm.ShowDialog();
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
                SettoriView settoriView = new SettoriView();
                settoriView.GestoreGiardino = _gestioneGiardino;
                settoriView.Controller = this;
                settoriView.Dock = DockStyle.Fill;
                settoriForm.Text = "Gestione settori";
                settoriForm.Size = new System.Drawing.Size(900, 300);
                settoriForm.Controls.Add(settoriView);
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
                nuovoSettoreForm.Text = "Nuovo settore";
                nuovoSettoreForm.Size = new System.Drawing.Size(350, 220);
                nuovoSettoreForm.Controls.Add(nuovoSettView);
                var result = nuovoSettoreForm.ShowDialog();
            }
        }

        public void CreaSettore(string nomeSettore, double portataImpianto, Valvola valvola)
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
                    nuovoGiardinoForm.Text = "Nuovo giardino";
                    nuovoGiardinoForm.Size = new System.Drawing.Size(380, 170);
                    nuovoGiardinoForm.Controls.Add(nuovoGiardinoView);

                    var result2 = nuovoGiardinoForm.ShowDialog();

                    if (result2 == DialogResult.OK)
                    {
                        Giardino giardino = new Giardino();
                        _gestioneGiardino.Giardino = giardino;
                        _gestioneGiardino.Luogo = nuovoGiardinoView.Controls.Find("_provinceComboBox", false)[0].Text;
                       // _gestioneGiardino.AggiornaInfoMeteo();
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

        public void GestisciTimer()
        {
            using (var form = new Form())
            {
                GestoreTimerView timerView = new GestoreTimerView();
                timerView.GestoreGiardino = _gestioneGiardino;
                timerView.Controller = this;
                timerView.Dock = DockStyle.Fill;
                form.Size = new System.Drawing.Size(500, 400);
                form.Controls.Add(timerView);
                form.ShowDialog();
            }
        }

        public void GestisciCisterna()
        {
            using (var form = new Form())
            {
                GestisciCisternaView cisternaView = new GestisciCisternaView();
                cisternaView.GestoreGiardino = _gestioneGiardino;
                cisternaView.Controller = this;
                cisternaView.Dock = DockStyle.Fill;
                form.Size = new System.Drawing.Size(600, 300);
                form.Controls.Add(cisternaView);
                form.ShowDialog();
            }
        }

        public void CreaNuovaCisterna(double portata, double capacità)
        {
            ICisterna cisterna = new Cisterna(portata, capacità);
            _gestioneGiardino.Giardino.Cisterna = cisterna;
        }

        public void CreaNuovaPianta(string nomeBotanico, string nomeComune, double area, string nomeSettore)
        {
            IPianta pianta = new Pianta(nomeBotanico, nomeComune, area);
            ISettore settore = _gestioneGiardino.Giardino.GetSettore(nomeSettore);
            settore.AddPianta(pianta);
        }
    }
}
