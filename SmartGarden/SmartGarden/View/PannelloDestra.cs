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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnModelChanged(object sender, EventArgs e)
        {
            if (sender is IGiardino)
            { 
                IGiardino giardino = GestoreGiardino.Giardino;

                PescaInfoDaModel();
            }
            else
            {
                _giardinoNameLabel.Text = GestoreGiardino.Luogo;
                PescaInfoDaModel();
            }
        }

        private void PescaInfoDaModel()
        {
            IGiardino giardino = GestoreGiardino.Giardino;

            if(giardino.Cisterna != null)
            { 
                _capacitàLabel.Text = giardino.Cisterna.Capienza + " l";
                _portataLabel.Text = giardino.Cisterna.Portata + " l/s";
            }
            else
            {
                _capacitàLabel.Text = "*cisterna non presente*";
                _portataLabel.Text = "*cisterna non presente*";
            }

            _numeroSettoriLabel.Text = giardino.GetNomiSettori().Count().ToString();
            _numeroPianteLabel.Text = giardino.NumeroPianteTotali.ToString();

            /*TODO messagepump
            _precipitazioniLabel.Text = GestoreGiardino.Precipitazioni + " mm";
            _temperaturaLabel.Text = GestoreGiardino.Temperatura + " °C";*/

            _prossimaIrrigazioneLabel.Text = GestoreGiardino.OraInizioInnaffiatura.ToString();
            _intervalloIrrigazione.Text = GestoreGiardino.Intervallo.TotalHours.ToString() + " h";

            SistemaRighe();
        }

        private void SistemaRighe()
        {
            _tableLayoutPanel.RowStyles.Add(new RowStyle());
        }

        private void _settoriPicture_Click(object sender, EventArgs e)
        {
            Controller.CreaSettoriView();
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
            Controller.CreaGestisciCisternaView();
        }

        #region useless
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
        #endregion
    }
}
