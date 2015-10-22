using System;
using System.Timers;

namespace SmartGarden.Model
{
    abstract class Valvola : IOpenClose
    {
        private String _name;

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public virtual void Close(object source, EventArgs e)
        {
            MessagePump.SendMessage("sono : " + _name + " mi chiudo");
        }

        public virtual void Open(object source, EventArgs e)
        {
            MessagePump.SendMessage("sono : " + _name + " mi chiudo");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
