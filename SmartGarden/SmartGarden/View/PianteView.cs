using System;
using System.Windows.Forms;
using SmartGarden.Model;

namespace SmartGarden.View
{
    partial class PianteView : MainView
    {
        private ISettore _settore;
        
        private int id = 1;

        public PianteView(ISettore settore)
        {
            InitializeComponent();
            _settore = settore;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dataGridView.CellClick += MostraGestoriInfoPianta;
            DateTime tomorrow = DateTime.Now.AddDays(1);

            foreach (Guid guidPianta in _settore.GetGuidPiante())
            {
                IPianta pianta = _settore.GetPianta(guidPianta);
                _dataGridView.Rows.Add(pianta.Guid, pianta.NomeComune, pianta.NomeBotanico, 
                    pianta.FabbisognoPiantaAttuale(DateTime.Now, tomorrow) + " mm", "Mostra Gestori");
            }

        }

        private void MostraGestoriInfoPianta(object sender, DataGridViewCellEventArgs e)
        {
            Guid guidPianta = Guid.Parse(_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()); //GUID

            IPianta pianta = _settore.GetPianta(guidPianta);

            if (_dataGridView.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1) //aggiungi gestore
            {
                Controller.CreaPiantaView(pianta);
            }
        }
    }
}
