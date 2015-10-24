using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartGarden.Model.Gestore_Informazioni.Fornitori;
using System.IO;

namespace SmartGarden.View
{
    partial class MeteoView : MainView
    {
        public MeteoView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FornitoreInformazioniMeteoHttp fornitoreMeteo = FornitoreInformazioniMeteoHttp.GetFornitore();
            AggiornaInfoMeteo(fornitoreMeteo);
        }

        private void AggiornaInfoMeteo(FornitoreInformazioniMeteoHttp fornitoreMeteo)
        {
            double temperatura = fornitoreMeteo.GetDato("temperature");
            double precipitazioni = fornitoreMeteo.GetDato("precipitation");
            double pressione = fornitoreMeteo.GetDato("pressure");
            double umidità = fornitoreMeteo.GetDato("humidity");
            double livelloNuvole = fornitoreMeteo.GetDato("clouds");

            _temperaturaTextBox.Text = temperatura + " °C";
            _precipitazioniTextBox.Text = precipitazioni + " mm";
            _pressioneTextBox.Text = pressione + " hPa";
            _umiditàTextBox.Text = umidità + " %";

            CaricaImmagineMeteo(livelloNuvole, precipitazioni);
        }

        private void CaricaImmagineMeteo(double livelloNuvole, double precipitazioni)
        {
            if (livelloNuvole < 20)
            {
                _meteoPictureBox.Image = Properties.Resources._1;
            }
            else if (livelloNuvole >= 20 && livelloNuvole < 40)
            {
                _meteoPictureBox.Image = Properties.Resources._2;
            }
            else if (livelloNuvole >= 40 && livelloNuvole < 60)
            {
                _meteoPictureBox.Image = Properties.Resources._3;
            }
            else if (livelloNuvole >= 60 && livelloNuvole < 85)
            {
                if(precipitazioni != 0)
                    _meteoPictureBox.Image = Properties.Resources._4;
                else
                    _meteoPictureBox.Image = Properties.Resources._3;
            }
            else if (livelloNuvole >= 85)
            {
                _meteoPictureBox.Image = Properties.Resources._5;
            }
            
        }
    }
}
