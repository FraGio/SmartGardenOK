using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class Giardino:IGiardino
    {
        public ICisterna Cisterna { get; set; }
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

            DateTime turno = new DateTime(0);
            long tot = 0;
            foreach(Settore settore in _settori.Values)
            {
               TurnoItem turnoItem = new TurnoItem();
                turnoItem.Attesa = turno;
                double portata = settore.GetPortataVolumetricaSecondo(Cisterna.Portata);
                long durata = (long)(settore.GetFabisogno(inizio,fine) / portata);
                tot += durata;
                TimeSpan dur = new TimeSpan(durata);
                turnoItem.Durata = dur;
                turno = turno.AddSeconds(durata);
            }
            TurnoItem itemTurno = new TurnoItem();
            itemTurno.Attesa = new DateTime(0);
            itemTurno.Durata = new TimeSpan(tot);
            turni.Add(itemTurno);

            return turni;
        }
    }

    class TurnoItem
    {
        public DateTime Attesa { get; set; }
        public TimeSpan Durata { get; set; }
        private List<IOpenClose> _methods;
        
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
