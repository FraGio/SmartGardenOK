using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden.View
{
    partial class GestoreTimerView : MainView
    {
        public GestoreTimerView()
        {
            InitializeComponent();
            _giornoTextBox.TextChanged += AbilitaConferma;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            for(int i=0; i<24; i++)
            {
                _oreComboBox.Items.Add(i);
                _oreInizioComboBox.Items.Add(i);
            }
            _oreComboBox.SelectedIndex = 0;
            _oreInizioComboBox.SelectedIndex = 0;

            for (int i = 0; i < 59; i++)
            {
                _minutiComboBox.Items.Add(i);
                _minutiInizioCombobox.Items.Add(i);
            }
            _minutiComboBox.SelectedIndex = 0;
            _minutiInizioCombobox.SelectedIndex = 0;

            _irrigazioneTextBox.Text = GestoreGiardino.OraInizioInnaffiatura.ToString();
        }

        private void _confermaButton_Click(object sender, EventArgs e)
        {
            try
            {
                int intervalloGiorni = Int32.Parse(_giornoTextBox.Text);
                TimeSpan orarioInizio = new TimeSpan((int)_oreInizioComboBox.SelectedItem, (int)_minutiInizioCombobox.SelectedItem, 0);
                TimeSpan intervallo = new TimeSpan(intervalloGiorni, (int)_oreInizioComboBox.SelectedItem, (int)_minutiInizioCombobox.SelectedItem, 0);

                DateTime ora = DateTime.Now.Date + orarioInizio;
                DateTime interv = ora + intervallo;


            }
            catch
            {
                throw new ArgumentException("Giorno deve essere un valore numerico!");
            }
        }

        private void AbilitaConferma(object sender, EventArgs e)
        {
            _confermaButton.Enabled = true;
        }
    }
}
