using SmartGarden.Model.Gestore_Informazioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SmartGarden.Model
{
    class Settore : ISettore
    {
        public IOpenClose ValvolaSettore { get; set; }
        private String _nome;
        private double _portataImpianto;
        private IDictionary<Guid,IPianta> _piante;

        public event EventHandler SettoreUpdated;
        protected virtual void OnSettoreUpdated()
        {
            if (SettoreUpdated != null)
                SettoreUpdated(this, EventArgs.Empty); //aggiorna la view
        }

        public Settore(string nome, double portata=0)
        {
            _nome = nome;
            _portataImpianto = portata;
            _piante = new Dictionary<Guid,IPianta>();
        }

        public String Nome
        {
            get { return _nome; }
        }

        public double PortataImpianto
        {
            get { return _portataImpianto; }
            set
            {
                if (value >= 0)
                    _portataImpianto = value;
            }
        }

        public bool AddPianta(IPianta pianta)
        {
            if (_piante.ContainsKey(pianta.Guid))
            {
                return false;
            }
            else
            {
                _piante.Add(pianta.Guid, pianta);
                OnSettoreUpdated();
            }
            return true;
        }
        public bool RemovePianta(IPianta pianta)
        {
            if (!_piante.ContainsKey(pianta.Guid))
            {
                return false;
            }
            else
            {
                IFactoryGestioneInfoRef fac = FactoryGestoreInformazioni.GetFactory();
                fac.Remove(pianta.GestoreInformazioni);
                _piante.Remove(pianta.Guid);
                OnSettoreUpdated();
            }
            return true;
        }
        public bool HasPianta(IPianta pianta)
        {
            return _piante.ContainsKey(pianta.Guid);
        }
        public IPianta GetPianta(Guid guid)
        {
            return _piante[guid];
        }
        public IEnumerable<Guid> GetGuidPiante()
        {
            return _piante.Keys;
        }

        public void Delete()
        {
            IFactoryGestioneInfoRef fac = FactoryGestoreInformazioni.GetFactory();
            foreach (IPianta pianta in _piante.Values)
            {
                fac.Remove(pianta.GestoreInformazioni);
            }
        }

        public double GetFabisogno(DateTime inizio,DateTime fine)
        {
            double tot=0;
            foreach(Guid guid in _piante.Keys)
            {
                tot += _piante[guid].FabbisognoPiantaAttuale(inizio,fine);
            }
            return tot;
        }

        public double GetPortataVolumetricaSecondo(double portata)
        {
            return _portataImpianto;
        }

     
    }
}
