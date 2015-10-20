using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SmartGarden.Model.Gestore_Informazioni;
using SmartGarden.Model;

namespace SmartGarden.View
{
    public partial class PianteView : MainView
    {
        private Settore _settore;

        private IFactoryGestoreInformazioni _fac;
        private Dictionary<Type, Type> _type;
        private int id = 1;

        public PianteView(Settore settore)
        {
            InitializeComponent();
            _settore = settore;
            _fac = FactoryGestoreInformazioni.GetFactory();
            _type = new Dictionary<Type, Type>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dataGridView.CellClick += GestoriInfoPianta;

            IInspector insp = ProviderVisitorInspector.GetInspector();
            

            foreach (Pianta pianta in _settore.Piante.ListaPiante)
            {
                _dataGridView.Rows.Add(id++, pianta.NomeComune, pianta.NomeBotanico, 
                    pianta.FabbisognoPiantaAttuale() + " mm", "", "", "Aggiungi", "Mostra Gestori");
            }

            Provider.Items.AddRange(insp.GetListProvider().ToArray());
            Visitor.Items.AddRange(insp.GetListVisitor().ToArray());
        }

        private void GestoriInfoPianta(object sender, DataGridViewCellEventArgs e)
        {
            int idPianta = Int32.Parse(_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            string nomeBotanico = _dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            Type provider = (Type)_dataGridView.Rows[e.RowIndex].Cells[4].Value;
            Type visitor = (Type)_dataGridView.Rows[e.RowIndex].Cells[5].Value;

            if (_dataGridView.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1 && 
                provider != null && visitor != null) //aggiungi gestore
            {
                _type.Add(provider, visitor);
                IPianta pianta = _settore.GetPianta(idPianta);
                _type.Add(provider, visitor); 
                
                _dataGridView.Rows[e.RowIndex].Cells[4].Value = ""; //pulizia cella
                _dataGridView.Rows[e.RowIndex].Cells[5].Value = ""; //pulizia cella

            }
            else if (_dataGridView.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1) //visualizza gestori pianta
            {
                IPianta pianta = new Pianta(nomeBotanico);
                Dictionary<Type, Type> providersVistorPianta = pianta.GestoreInformazioni.GetTypeProviders();
                string result = CreaStringaDaDizionario(providersVistorPianta);
                MessageBox.Show(providersVistorPianta.ToString());
            }
        }

        private string CreaStringaDaDizionario(Dictionary<Type, Type> dizionario)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Type provider in dizionario.Keys)
            {
                Type visitor;
                dizionario.TryGetValue(provider, out visitor);
                sb.AppendLine("Provider: " + provider.ToString() + " ; Visitor: " + visitor.ToString());
            }

            return sb.ToString();
        }
    }
}
