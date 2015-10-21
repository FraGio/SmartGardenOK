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
    partial class NuovaPiantaView : MainView
    {
        private string _nomeSettore;

        public NuovaPiantaView(string nomeSettore)
        {
            InitializeComponent();

            _nomeSettore = nomeSettore;
        }

        private void _aggiungiButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_nomeBotanicoTextBox.Text) && !string.IsNullOrWhiteSpace(_nomeComuneTextBox.Text))
            {
                double area = double.Parse(_areaTextBox.Text);
                Controller.CreaNuovaPianta(_nomeBotanicoTextBox.Text, _nomeComuneTextBox.Text, area, _nomeSettore);
                this.ParentForm.Close();
            }
        }
    }
}
