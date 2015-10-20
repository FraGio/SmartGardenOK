using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.IO;
using SmartGarden.Model.Gestore_Informazioni;

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

            IInspector insp = ProviderVisitorInspector.Get();
            

            string[] visitors = { "visitor1", "visitor2" };
            string[] providers = { "provider1", "provider2", "provider3" };

            foreach (Pianta pianta in _settore.Piante.ListaPiante)
            {
                _dataGridView.Rows.Add(id++, pianta.NomeComune, pianta.NomeBotanico, 
                    pianta.FabbisognoPiantaAttuale() + " mm", "", "", "Aggiungi", "Mostra Gestori");
            }

            Provider.Items.AddRange(insp.GetListProvider().ToArray());
            Visitor.Items.AddRange(insp.GetListVisitor().ToArray());
            /*Visitor.Items.AddRange(visitors);
            Provider.Items.AddRange(providers);*/
        }

        private void GestoriInfoPianta(object sender, DataGridViewCellEventArgs e)
        {
            int idPianta = Int32.Parse(_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Type provider = (Type)_dataGridView.Rows[e.RowIndex].Cells[4].Value;
            Type visitor = (Type)_dataGridView.Rows[e.RowIndex].Cells[5].Value;

            if (_dataGridView.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1 && 
                provider != null && visitor != null) //aggiungi gestore
            {

                

                _type.Add(provider, visitor);
                Pianta.gestoreInfo(_fac.GetGestore(_type));

                string salvaGestoriString = idPianta + ";" + provider + ";" + visitor + Environment.NewLine;
                File.AppendAllText("gestoriPiante", salvaGestoriString);
                
                _dataGridView.Rows[e.RowIndex].Cells[4].Value = ""; //pulizia cella
                _dataGridView.Rows[e.RowIndex].Cells[5].Value = ""; //pulizia cella

            }
            else if (_dataGridView.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1) //visualizza gestori pianta
            {
                char[] splitchar = { ';' };
                StringBuilder sb = new StringBuilder();

                foreach (string linea in File.ReadAllLines("gestoriPiante"))
                {
                    if (linea.Split(splitchar)[0] == idPianta.ToString()) {
                        sb.AppendLine(linea.Split(splitchar)[1] + " " + linea.Split(splitchar)[2]);
                    }
                }
                MessageBox.Show(sb.ToString());
            }
        }
    }
}
