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

namespace SmartGarden.View
{
    public partial class PiantaView : MainView
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

            _aggiungiButton.Click += AggiungiProviderVisitor;
            _finalizzaButton.Click += FinalizzaGestore;


            _providerComboBox.Items.AddRange(insp.GetListProvider().ToArray());
            _visitorComboBox.Items.AddRange(insp.GetListVisitor().ToArray());
        }

        private void AggiungiProviderVisitor(object sender, EventArgs e)
        {
            if(_providerComboBox.SelectedValue != null && _visitorComboBox.SelectedValue != null)
            {
                Type provider = (Type)_providerComboBox.SelectedValue;
                Type visitor = (Type)_visitorComboBox.SelectedValue;
                if (!_types.ContainsKey(provider))
                { 
                    _types.Add(provider, visitor);
                    _textBox.AppendText("Provider: " + provider.ToString() + " ; " + "Visitor: " + visitor.ToString());
                }
            }
        }

        private void FinalizzaGestore(object sender, EventArgs e)
        {
            IFactoryGestoreInformazioni factoryGestioneInfo = FactoryGestoreInformazioni.GetFactory();

            if (_pianta.Gestore == null)
            {
                _pianta.Gestore = factoryGestioneInfo.GetGestore(_types);
            }
            else
            {
                _pianta.Gestore = factoryGestioneInfo.Modifica(pianta.Gestore, _types);
            }

            this.ParentForm.Close();
        }

        private void _rimuoviButton_Click(object sender, EventArgs e)
        {
            if (_providerComboBox.SelectedValue != null && _visitorComboBox.SelectedValue != null)
            {
                Type provider = (Type)_providerComboBox.SelectedValue;
                Type visitor = (Type)_visitorComboBox.SelectedValue;
                if (_types.ContainsKey(provider))
                {
                    _types.Remove(provider);
                    _textBox.Clear();
                }
                foreach(Type prov in _types.Keys)
                {
                    Type vis;
                    _types.TryGetValue(prov, out vis);
                    _textBox.AppendText("Provider: " + prov.ToString() + " ; " + "Visitor: " + vis.ToString());
                }
            }
        }
    }
}
