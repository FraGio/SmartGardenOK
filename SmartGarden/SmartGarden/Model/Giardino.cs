using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartGarden.Model
{
    class Giardino : IGiardino
    {
        public ICisterna Cisterna { get; set; }
        public event EventHandler Changed;

        public int NumeroPianteTotali
        {
            get
            {
                int tot = 0;
                foreach(Settore set in _settori.Values)
                {
                    tot += set.GetGuidPiante().Count();
                }
                return tot;
            }
        }
        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty); //aggiorna la view
        }


        private Dictionary<string,ISettore> _settori;

        public Giardino()
        {
            _settori = new Dictionary<string, ISettore>();
        }

        public IEnumerable<string> GetNomiSettori()
        {
            return _settori.Keys;
        } 

        public ISettore GetSettore(string name)
        {
            return _settori[name];
        }

        public IEnumerable<TurnoItem> GetTurni(DateTime inizio,DateTime fine)
        {
            List<TurnoItem> turni = new List<TurnoItem>();

            TimeSpan turno = new TimeSpan(0);
            long tot = 0;
            foreach(Settore settore in _settori.Values)
            {
               TurnoItem turnoItem = new TurnoItem();
                turnoItem.Attesa = turno;
                double portata = settore.GetPortataVolumetricaSecondo(Cisterna.Portata);
                long durata = (long)(settore.GetFabisogno(inizio,fine) / portata);
                tot += durata;
                TimeSpan dur = new TimeSpan(durata*TimeSpan.TicksPerSecond);
                turnoItem.Durata = dur;
                turno = turno.Add(new TimeSpan(durata*TimeSpan.TicksPerSecond));
            }
            TurnoItem itemTurno = new TurnoItem();
            itemTurno.Attesa = new TimeSpan(0);
            itemTurno.Durata = new TimeSpan(tot*TimeSpan.TicksPerSecond);
            turni.Add(itemTurno);

            return turni;
        }

        public bool AddSettore(ISettore settore)
        {
            if (_settori.ContainsKey(settore.Nome))
                return false;
            _settori.Add(settore.Nome, settore);
            OnChanged();
            return true;
        }

        public bool RemoveSettore(string settore)
        {
            if (!_settori.ContainsKey(settore))
                return false;

            _settori.Remove(settore);
            OnChanged();
            return true;
        }
    }

    class TurnoItem
    {
        public TimeSpan Attesa { get; set; }
        public TimeSpan Durata { get; set; }
        private List<IOpenClose> _methods;
        
        public TurnoItem()
        {
            _methods = new List<IOpenClose>();
        }

        public void AddOpenClose(IOpenClose method)
        {
            _methods.Add(method);
        }

        public IEnumerable<IOpenClose> Mehtods
        {
            get
            {
                return _methods;
            }
        }
    }


    
}
