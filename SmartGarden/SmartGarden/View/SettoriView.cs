using System;
using SmartGarden.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartGarden.View
{
    public partial class _settoriView : MainView
    {
        private List<Settore> _settori;

        public _settoriView()
        {
            InitializeComponent();
            _dataGridView.CellClick += ApriViewPiante;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _settori = GestoreGiardino.Giardino.Settori.ListaSettori;

            foreach (Settore settore in _settori)
            {
                _dataGridView.Rows.Add(settore.Nome, settore.Piante.ListaPiante.Count,
                    settore.Piante.GetFabbisognoTotale() + " mm", "3 ore", "Piante");
            }
        }

        private void ApriViewPiante(object sender, DataGridViewCellEventArgs e)
        {
            if (_dataGridView.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                string nomeSettore = _dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Controller.CaricaViewPiante(nomeSettore);
            }
        }
    }
}
