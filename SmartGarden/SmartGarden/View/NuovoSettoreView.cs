using System;
using SmartGarden.Model;

namespace SmartGarden.View
{
    partial class NuovoSettoreView : MainView
    {
        public NuovoSettoreView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            /*List<Valvola> valvoleSettore = new List<Valvola>();
            Valvola valvola = new Valvola();
            valvola.Name = "Valvola SETT-01";
            valvole.Add(valvola);
            valvola = new ValvolaDiSicurezza();
            valvola.Name = "Valvola ETR-45";
            valvole.Add(valvola);
            
            _valvolaComboBox.Items.AddRange(valvoleSettore.ToArray());*/
        }

        private void _aggiungiButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_nomeTextBox.Text) && !string.IsNullOrWhiteSpace(_portataImpiantoTextBox.Text))
            {
                Controller.CreaSettore(_nomeTextBox.Text, double.Parse(_portataImpiantoTextBox.Text), (Valvola)_valvolaComboBox.SelectedValue);
                this.ParentForm.Close();
            }
        }
    }
}
