using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartGarden.View;

namespace SmartGarden.View
{
    public partial class NuovoGiardinoView : MainView
    {
        public NuovoGiardinoView()
        {
            InitializeComponent();
            _provinceComboBox.SelectedIndexChanged += AbilitaOkButton;
        }

        private void AbilitaOkButton(object sender, EventArgs e)
        {
            _okButton.Enabled = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Controller.CaricaProvinceComboBox(_provinceComboBox);
        }
    }
}
