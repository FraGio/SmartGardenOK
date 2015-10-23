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

            List<IvalvolaDiSicurezza> valvole = new List<IvalvolaDiSicurezza>();
            ValvolaDiSicurezza valvola = new ValvolaDiSicurezza();
            valvola.Name = "Valvola FGH-02";
            valvole.Add(valvola);
            valvola = new ValvolaDiSicurezza();
            valvola.Name = "Valvola ETR-45";
            valvole.Add(valvola);

            _valvolaSicurezzaComboBox.Items.AddRange(valvole.ToArray());
            
            List<IRilevatorePressione> sensori = new List<IRilevatorePressione>();
            IRilevatorePressione sensore = new SensorePressione("Sensore S01");
            sensori.Add(sensore);
            sensore = new SensorePressione("Sensore S02");
            sensori.Add(sensore);

            _sensorePressioneComboBox.Items.AddRange(sensori.ToArray());
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
                catch
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
