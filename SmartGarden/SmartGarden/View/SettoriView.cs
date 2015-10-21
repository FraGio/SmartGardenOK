using System;
using System.Windows.Forms;
using SmartGarden.Model;
using System.Linq;

namespace SmartGarden.View
{
    partial class SettoriView : MainView
    {

        public SettoriView()
        {
            InitializeComponent();
            _dataGridView.CellClick += GestisciClick;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            foreach (string nomeSettore in GestoreGiardino.Giardino.GetNomiSettori())
            {
                ISettore settore = GestoreGiardino.Giardino.GetSettore(nomeSettore);

                _dataGridView.Rows.Add(settore.Nome, settore.GetGuidPiante().Count().ToString(),
                    settore.GetFabisogno(DateTime.Now, DateTime.Now.AddDays(1)) + " mm", "3 ore", "Vedi piante", "Rimuovi settore");
            }
        }

        private void GestisciClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeSettore = _dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (_dataGridView.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                Controller.CaricaViewPiante(nomeSettore);
            }
            else if (_dataGridView.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                Controller.CancellaSettore(nomeSettore);
                _dataGridView.Update();
                _dataGridView.Refresh();
            }
        }

        private void _aggiungiSettoreButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
