using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartGarden.View;
using SmartGarden.Model.Gestore_Informazioni;
using SmartGarden.Model;

namespace SmartGarden.View
{
    partial class PiantaView : MainView
    {
        private IPianta _pianta;
        private Dictionary<Type, Type> _types;

        public PiantaView(IPianta pianta)
        {
            InitializeComponent();
            _types = new Dictionary<Type, Type>();
            _pianta = pianta;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            IInspector insp = ProviderVisitorInspector.GetInspector();

            if(_pianta.GestoreInformazioni != null)
            {
                _types = _pianta.GestoreInformazioni.GetTypeProviders();

                AggiornaTextBox();
            }

            _aggiungiButton.Click += AggiungiProviderVisitor;
            _finalizzaButton.Click += FinalizzaGestore;

            /*_providerComboBox.Items.AddRange(insp.GetListProvider().ToArray());
            _visitorComboBox.Items.AddRange(insp.GetListVisitor().ToArray());*/

            #region PROVA CARICAMENTO COMBO ALTERNATIVA
            Dictionary<string, Type> providers = new Dictionary<string, Type>();
            foreach (Type prov in insp.GetListProvider())
            {
                providers.Add(prov.Name, prov);
            }
            _providerComboBox.DataSource = new BindingSource(providers, null);
            _providerComboBox.DisplayMember = "Key";
            _providerComboBox.ValueMember = "Value";

            Dictionary<string, Type> visitors = new Dictionary<string, Type>();
            foreach (Type visit in insp.GetListVisitor())
            {
                visitors.Add(visit.Name, visit);
            }
            _visitorComboBox.DataSource = new BindingSource(visitors, null);
            _visitorComboBox.DisplayMember = "Key";
            _visitorComboBox.ValueMember = "Value";
            #endregion
        }

        private void AggiungiProviderVisitor(object sender, EventArgs e)
        {
            if(_providerComboBox.SelectedItem != null && _visitorComboBox.SelectedItem != null)
            {
                Type provider = ((KeyValuePair<string, Type>)_providerComboBox.SelectedItem).Value;
                Type visitor = ((KeyValuePair<string, Type>)_visitorComboBox.SelectedItem).Value;
                if (!_types.ContainsKey(provider))
                { 
                    _types.Add(provider, visitor);
                    _textBox.Text += "Provider: " + provider.Name + " ; " + "Visitor: " + visitor.Name +  Environment.NewLine;
                }
            }
        }

        private void FinalizzaGestore(object sender, EventArgs e)
        {
            IFactoryGestoreInformazioni factoryGestioneInfo = FactoryGestoreInformazioni.GetFactory();

            if (_pianta.GestoreInformazioni == null)
            {
                _pianta.GestoreInformazioni = factoryGestioneInfo.GetGestore(_types);
            }
            else
            {//TODO modifica gestore informazioni risoluzione interfaccia
                _pianta.GestoreInformazioni = factoryGestioneInfo.Modifica((GestoreInformazioni)_pianta.GestoreInformazioni, _types);
            }

            this.ParentForm.Close();
        }

        private void _rimuoviButton_Click(object sender, EventArgs e)
        {
            if (_providerComboBox.SelectedItem != null && _visitorComboBox.SelectedItem != null)
            {
                Type provider = ((KeyValuePair<string, Type>)_providerComboBox.SelectedItem).Value;
                Type visitor = ((KeyValuePair<string, Type>)_visitorComboBox.SelectedItem).Value;
                if (_types.ContainsKey(provider))
                {
                    _types.Remove(provider);
                    _textBox.Clear();
                }

                AggiornaTextBox();
            }
        }

        private void AggiornaTextBox()
        {
            foreach (Type prov in _types.Keys)
            {
                Type vis;
                _types.TryGetValue(prov, out vis);
                _textBox.AppendText("Provider: " + prov.Name + " ; " + "Visitor: " + vis.Name);
            }
        }
    }
}
