using System;
using SmartGarden.Model;
using System.Collections.Generic;
using System.Windows.Forms;

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
            
            Dictionary<string, ValvolaDiSettore> dizionarioValvole = new Dictionary<string, ValvolaDiSettore>();
            ValvolaDiSettore valvola = new ValvolaDiSettore();
            valvola.Name = "Valvola SETT-01";
            dizionarioValvole.Add(valvola.Name, valvola);
            valvola = new ValvolaDiSettore();
            valvola.Name = "Valvola SETT-02";
            dizionarioValvole.Add(valvola.Name, valvola);

            _valvolaComboBox.DataSource = new BindingSource(dizionarioValvole, null);
            _valvolaComboBox.DisplayMember = "Key";
            _valvolaComboBox.ValueMember = "Value";
        }

        private void _aggiungiButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_nomeTextBox.Text) && !string.IsNullOrWhiteSpace(_portataImpiantoTextBox.Text))
            {
                Controller.CreaSettoreView(_nomeTextBox.Text, double.Parse(_portataImpiantoTextBox.Text), (Valvola)_valvolaComboBox.SelectedValue);
                this.ParentForm.Close();
            }
        }
    }
}
