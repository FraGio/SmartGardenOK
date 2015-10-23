using System;
using System.Windows.Forms;
using SmartGarden.Model;

namespace SmartGarden.View
{
    partial class PianteView : MainView
    {
        private ISettore _settore;

        public PianteView(ISettore settore)
        {
            InitializeComponent();
            _settore = settore;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dataGridView.CellClick += MostraGestoriInfoPianta;

            CaricaPiante();
        }

        private void MostraGestoriInfoPianta(object sender, DataGridViewCellEventArgs e)
        {
            Guid guidPianta = Guid.Parse(_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()); //GUID

            IPianta pianta = _settore.GetPianta(guidPianta);

            if (_dataGridView.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1) //aggiungi gestore
            {
                Controller.CreaGestioneInfoPiantaView(pianta);
            }
            else if(_dataGridView.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1) //cancella pianta
            {
                Controller.CancellaPianta(pianta, _settore);
                CaricaPiante();
            }
            else if (_dataGridView.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                Controller.CreaGestoreFabbisognoPiantaView(pianta);
            }
        }

        private void _aggiungiPiantaButton_Click(object sender, EventArgs e)
        {
            Controller.CreaAggiungiPiantaView(_settore.Nome, this.ParentForm);
           
        }

        private void CaricaPiante()
        {
            _dataGridView.Rows.Clear();

            foreach (Guid guidPianta in _settore.GetGuidPiante())
            {
                IPianta pianta = _settore.GetPianta(guidPianta);
                _dataGridView.Rows.Add(pianta.Guid, pianta.NomeComune, pianta.NomeBotanico,
                    Convert.ToInt32(pianta.FabbisognoPiantaAttuale(DateTime.Now, DateTime.Now.AddDays(1))) + 
                    " mm", "Mostra Gestori", "Gestione Fabbisogno","Elimina pianta");
            }
        }

        private void _homeButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.ParentForm.Close();
        }
    }
}
