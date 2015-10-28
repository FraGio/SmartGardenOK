using System;
using System.Timers;

namespace SmartGarden.Model
{
    public abstract class Valvola : IOpenClose
    {
        private String _name;
        protected IMessagePump _mess= MessagePump.GetMessagePump();

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
            _mess.SendMessage("sono : " + _name + " mi chiudo");
        }

        public virtual void Open(object source, EventArgs e)
        {
            _mess.SendMessage("sono : " + _name + " mi chiudo");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
