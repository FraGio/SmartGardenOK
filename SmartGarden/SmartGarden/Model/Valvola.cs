using System;
using System.Timers;

namespace SmartGarden.Model
{
    class Valvola : IOpenClose
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

        public void Close(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("sono : " + _name + " mi chiudo");
        }

        public void Open(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("sono : " + _name + " mi apro");
        }

       
    }
}
