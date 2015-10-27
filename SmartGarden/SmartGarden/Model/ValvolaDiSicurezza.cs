using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class ValvolaDiSicurezza : Valvola, IvalvolaDiSicurezza
    {
        public string Nome
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public event EventHandler stateChanged;

        public override void Close(object source, EventArgs e)
        {
            base.Close(source, e);
            OnStateChanged();
            
        }

        protected virtual void OnStateChanged()
        {
            if (stateChanged != null)
                stateChanged(this, EventArgs.Empty);
        }

        public override void Open(object source, EventArgs e)
        {
            base.Open(source, e);
            OnStateChanged();
        }
    }
}
