using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartGarden.Model;

namespace SmartGarden.View 
{
    partial class GestisciFabbisognoPiantaView : MainView
    {
        private IPianta _pianta;

        public GestisciFabbisognoPiantaView(IPianta pianta)
        {
            InitializeComponent();
            _pianta = pianta;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _idPiantaTextBox.Text = _pianta.Guid.ToString();

            if(_pianta.FabbisogniPianta.Count != 0)
            {
                foreach (FabbisognoGiornalieroPeriodo fabbisogno in _pianta.FabbisogniPianta)
                {
                    AggiungiFabbisogno(fabbisogno.InizioPeriodo, fabbisogno.FinePeriodo, fabbisogno.FabbisognoAcquaGiornaliero);
                }
            }
        }

        private void _aggiungiButton_Click(object sender, EventArgs e)
        {
            DateTime dataInizio = _inizioDatePicker.Value;
            DateTime dataFine = _fineDatePicker.Value;

            if (!string.IsNullOrWhiteSpace(_quantitàAcquaTextBox.Text) && dataInizio < dataFine)
            {
                try {
                    _pianta.AddFabisogno(new FabbisognoGiornalieroPeriodo(dataInizio, dataFine, double.Parse(_quantitàAcquaTextBox.Text)));
                    AggiungiFabbisogno(dataInizio, dataFine, double.Parse(_quantitàAcquaTextBox.Text));
                }
                catch
                {
                    MessageBox.Show("Quantità d'acqua deve essere un valore numerico!");
                }
            }
        }

        private void AggiungiFabbisogno(DateTime inizio, DateTime fine, double quantitàAcqua)
        {
            _fabbisogniTextBox.AppendText("Inizio: " + inizio.ToShortDateString() +
                        " ; " + "Fine: " + fine.ToShortDateString() + " ; " +
                        "Fabbisogno giornaliero (mm): " + quantitàAcqua + Environment.NewLine);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void _rimuoviButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Questa operazione cancellerà tutti i fabbisogni della pianta.\r\nSei sicuro di voler procedere?", "Avviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _fabbisogniTextBox.Clear();
                //_pianta.FabbisogniPianta
            }
        }
    }
}
