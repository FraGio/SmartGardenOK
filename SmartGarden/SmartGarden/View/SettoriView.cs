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
            _dataGridView.CellClick += ApriViewPiante;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            foreach (string nomeSettore in GestoreGiardino.Giardino.GetNomiSettori())
            {
                ISettore settore = GestoreGiardino.Giardino.GetSettore(nomeSettore);

                _dataGridView.Rows.Add(settore.Nome, settore.GetGuidPiante().Count().ToString(),
                    settore.GetFabisogno(DateTime.Now, DateTime.Now.AddDays(1)) + " mm", "3 ore", "Piante");
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
