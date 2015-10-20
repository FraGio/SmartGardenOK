using System;

namespace SmartGarden.Model
{
    class Valvola : IOpenClose
    {
        private String _name;
        private IDisposable _unsubscriber;

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

        public void Apri(object sender, EventArgs e)
        {
            Console.WriteLine("sono : " + _name + " mi apro");
        }

        public void Chiudi(object sender, EventArgs e)
        {
            Console.WriteLine("sono : " + _name + " mi chiudo");
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
