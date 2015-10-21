using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden.View
{
    partial class GestisciCisternaView : MainView
    {
        public GestisciCisternaView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _guidCisternaTextBox.Text = GestoreGiardino.Giardino.Cisterna.Guid.ToString();
            _portataTextBox.Text = GestoreGiardino.Giardino.Cisterna.Portata.ToString();
            _capacitàTextBox.Text = GestoreGiardino.Giardino.Cisterna.Capienza.ToString();
        }
    }
}
