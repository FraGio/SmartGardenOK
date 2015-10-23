using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartGarden.Model;

namespace SmartGarden.View 
{
    partial class GestisciFabbisognoPiantaView : MainView
    {
        private IPianta _pianta;

        public GestisciFabbisognoPiantaView(IPianta pianta)
        {
            InitializeComponent();
            _pianta = pianta;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _idPiantaTextBox.Text = _pianta.Guid.ToString();
        }

        private void _aggiungiButton_Click(object sender, EventArgs e)
        {
            DateTime dataInizio = _inizioDatePicker.Value;
            DateTime dataFine = _fineDatePicker.Value;

            if (!string.IsNullOrWhiteSpace(_quantitàAcquaTextBox.Text) && dataInizio < dataFine)
            {
                _fabbisogniTextBox.AppendText("ID: " + _pianta + " ; " + "");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
