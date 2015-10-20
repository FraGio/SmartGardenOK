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

namespace SmartGarden.View
{
    public partial class PianteView : MainView
    {
        private Settore _settore;

        private IFactoryGestoreInformazioni _fac;
        
        private int id = 1;

        public PianteView(Settore settore)
        {
            InitializeComponent();
            _settore = settore;
            _fac = FactoryGestoreInformazioni.GetFactory();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dataGridView.CellClick += MostraGestoriInfoPianta;
            
            foreach (Pianta pianta in _settore.Piante.ListaPiante)
            {
                _dataGridView.Rows.Add(pianta.Guid, pianta.NomeComune, pianta.NomeBotanico,
                    pianta.FabbisognoPiantaAttuale() + " mm", "Mostra Gestori");
            }

        }

        private void MostraGestoriInfoPianta(object sender, DataGridViewCellEventArgs e)
        {
            int idPianta = Int32.Parse(_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()); //GUID

            IPianta pianta = _settore.GetPianta(idPianta);

            if (_dataGridView.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1) //aggiungi gestore
            {
                Controller.CreaPiantaView(pianta);
            }
        }
    }
}
