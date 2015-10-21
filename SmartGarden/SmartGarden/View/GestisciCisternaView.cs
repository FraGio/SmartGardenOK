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
        }

        private void _creaButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_nuovaCapacitàTextBox.Text) && !(string.IsNullOrWhiteSpace(_nuovaPortataTextBox.Text))){
                Controller.CreaNuovaCisterna(double.Parse(_nuovaPortataTextBox.Text), double.Parse(_nuovaCapacitàTextBox.Text));
                this.ParentForm.Close();
            }
        }

        private void CaricaDatiCisterna()
        {
            if (GestoreGiardino.Giardino.Cisterna != null)
            {
                _guidCisternaTextBox.Text = GestoreGiardino.Giardino.Cisterna.Guid.ToString();
                _portataTextBox.Text = GestoreGiardino.Giardino.Cisterna.Portata.ToString();
                _capacitàTextBox.Text = GestoreGiardino.Giardino.Cisterna.Capienza.ToString();
            }
        }
    }
}
