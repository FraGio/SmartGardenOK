using System;
using System.Windows.Forms;
using SmartGarden.Model;
using System.Linq;
using System.Collections.Generic;

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

            CaricaDati();
        }

        private void GestisciClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeSettore = _dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (_dataGridView.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1) //carica view piante
            {
                Controller.CreaPianteView(nomeSettore, this.ParentForm);
            }
            else if (_dataGridView.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1) //cancella settore
            {
                Controller.CancellaSettore(nomeSettore);
                _dataGridView.Rows.Clear();
                CaricaDati();
            }
        }

        private void _aggiungiSettoreButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void CaricaDati()
        {
            _dataGridView.Rows.Clear();

            foreach (string nomeSettore in GestoreGiardino.Giardino.GetNomiSettori())
            {
                ISettore settore = GestoreGiardino.Giardino.GetSettore(nomeSettore);
                _dataGridView.Rows.Add(settore.Nome, settore.GetGuidPiante().Count().ToString(),
                    Convert.ToInt32(settore.GetFabisogno(DateTime.Now, DateTime.Now.AddDays(1))) + " mm", "3 ore", "Vedi piante", "Rimuovi settore");
            }
        }
    }
}
