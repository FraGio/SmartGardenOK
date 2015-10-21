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
    partial class NuovoSettoreView : MainView
    {
        public NuovoSettoreView()
        {
            InitializeComponent();
        }

        private void _aggiungiButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_nomeTextBox.Text) && !string.IsNullOrWhiteSpace(_portataImpiantoTextBox.Text))
            {
                this.ParentForm.Close();
            }
        }
    }
}
