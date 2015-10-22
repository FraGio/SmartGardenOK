using System;
using SmartGarden.Model;
using System.Collections.Generic;

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

            List<ValvolaDiSettore> valvoleSettore = new List<ValvolaDiSettore>();
            ValvolaDiSettore valvola = new ValvolaDiSettore();
            valvola.Name = "Valvola SETT-01";
            valvoleSettore.Add(valvola);
            valvola = new ValvolaDiSettore();
            valvola.Name = "Valvola SETT-02";
            valvoleSettore.Add(valvola);
            
            _valvolaComboBox.Items.AddRange(valvoleSettore.ToArray());
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
