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

            _giardinoNameLabel.Text = GestoreGiardino.Luogo;
            _numeroSettoriLabel.Text = giardino.GetNomiSettori().Count().ToString();
            _numeroPianteLabel.Text = giardino.NumeroPianteTotali.ToString();
            _capacitàLabel.Text = giardino.Cisterna.Capienza + " l";
            _portataLabel.Text = giardino.Cisterna.Portata + " l/s";

            /*TODO messagepump
            _precipitazioniLabel.Text = GestoreGiardino.Precipitazioni + " mm";
            _temperaturaLabel.Text = GestoreGiardino.Temperatura + " °C";*/
            
            _prossimaIrrigazioneLabel.Text = GestoreGiardino.OraInizioInnaffiatura.ToString();
            _intervalloIrrigazione.Text = GestoreGiardino.Intervallo.ToString();

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

        private void _timerPicture_Click(object sender, EventArgs e)
        {
            Controller.GestisciTimer();
        }

        private void _cisternaPicture_Click(object sender, EventArgs e)
        {
            Controller.GestisciCisterna();
        }
    }
}
