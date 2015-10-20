using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using SmartGarden.Model;

namespace SmartGarden.View
{
    partial class PannelloDestra : MainView
    {
        public PannelloDestra()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //
        }

        private void _tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void _tableLayoutPanel_Paint_1(object sender, PaintEventArgs e)
        {
            //
        }
        protected override void OnModelChanged(object sender, EventArgs e)
        {
            IGiardino giardino = GestoreGiardino.Giardino;

            _giardinoNameLabel.Text = giardino.Luogo;
            _numeroSettoriLabel.Text = giardino.GetNomiSettori;
            _numeroPianteLabel.Text = giardino.Settori.NumeroPianteTotali().ToString();
            _capacitàLabel.Text = giardino.Cisterna.Capienza + " l";
            _portataLabel.Text = giardino.Cisterna.Portata + " l/s";
            _precipitazioniLabel.Text = GestoreGiardino.Precipitazioni + " mm";
            _temperaturaLabel.Text = GestoreGiardino.Temperatura + " °C";

            int i = 0;
            if(GestoreGiardino.MyTimer.GetTimerForElement("TimerPrincipale") != null) { 
                foreach (System.Timers.Timer timer in GestoreGiardino.MyTimer.GetTimerForElement("TimerPrincipale"))
                {
                    if (i == 0)
                        _prossimaIrrigazioneLabel.Text = (timer.Interval / 1000) + " secondi";
                    else
                        _durataProssimaIrrigazione.Text = (timer.Interval / 1000) + " secondi";

                    i++;
                }
            }
            else
            {
                _prossimaIrrigazioneLabel.Text = "Non impostata";
                _durataProssimaIrrigazione.Text = "Non impostata";
            }
            SistemaRighe();
        }

        private void SistemaRighe()
        {
            _tableLayoutPanel.RowStyles.Add(new RowStyle());
        }

        private void _settoriPicture_Click(object sender, EventArgs e)
        {
            Controller.GestisciSettori();
        }

        private void _nuovoGiardinoPicture_Click(object sender, EventArgs e)
        {
            Controller.NuovoGiardino();
        }
    }
}
