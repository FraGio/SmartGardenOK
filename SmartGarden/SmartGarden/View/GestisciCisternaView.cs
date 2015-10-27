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
    partial class GestisciCisternaView : MainView
    {
        public GestisciCisternaView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CaricaDatiCisterna();

            Dictionary<string, IvalvolaDiSicurezza> dizionarioValvole = new Dictionary<string, IvalvolaDiSicurezza>();
            IvalvolaDiSicurezza valvola = new ValvolaDiSicurezza();
            valvola.Nome = "Valvola FGH-02";
            dizionarioValvole.Add(valvola.Nome, valvola);
            valvola = new ValvolaDiSicurezza();
            valvola.Nome = "Valvola ETR-45";
            dizionarioValvole.Add(valvola.Nome, valvola);

            _valvolaSicurezzaComboBox.DataSource = new BindingSource(dizionarioValvole, null);
            _valvolaSicurezzaComboBox.DisplayMember = "Key";
            _valvolaSicurezzaComboBox.ValueMember = "Value";

            Dictionary<string, IRilevatorePressione> dizionarioSensori = new Dictionary<string, IRilevatorePressione>();
            IRilevatorePressione sensore = new SensorePressione("Sensore S01");
            dizionarioSensori.Add(sensore.Descrizione, sensore);
            sensore = new SensorePressione("Sensore S02");
            dizionarioSensori.Add(sensore.Descrizione, sensore);

            _sensorePressioneComboBox.DataSource = new BindingSource(dizionarioSensori, null);
            _sensorePressioneComboBox.DisplayMember = "Key";
            _sensorePressioneComboBox.ValueMember = "Value";
        }

        private void _creaButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_nuovaCapacitàTextBox.Text) && !(string.IsNullOrWhiteSpace(_nuovaPortataTextBox.Text))){
                try {
                    Controller.CreaNuovaCisterna(double.Parse(_nuovaPortataTextBox.Text), double.Parse(_nuovaCapacitàTextBox.Text));
                    GestoreGiardino.Giardino.Cisterna.ValvolaSicurezza = (IvalvolaDiSicurezza)_valvolaSicurezzaComboBox.SelectedValue;
                    GestoreGiardino.Giardino.Cisterna.SensorePressione = (IRilevatorePressione)_sensorePressioneComboBox.SelectedValue;
                    this.ParentForm.Close();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Portata e capacità devono essere valori numerici!");
                }
            }
        }

        private void CaricaDatiCisterna()
        {
            if (GestoreGiardino.Giardino.Cisterna != null)
            {
                _portataTextBox.Text = GestoreGiardino.Giardino.Cisterna.Portata.ToString();
                _capacitàTextBox.Text = GestoreGiardino.Giardino.Cisterna.Capienza.ToString();
            }
        }
    }
}
