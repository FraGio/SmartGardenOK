﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartGarden.Model
{
    class Giardino : IGiardino
    {
        private ICisterna _cisterna;
        public event EventHandler Changed;

        public int NumeroPianteTotali
        {
            get
            {
                int tot = 0;
                foreach(ISettore set in Settori.Values)
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


        private Dictionary<string,ISettore> Settori;

        public Giardino()
        {
            Settori = new Dictionary<string, ISettore>();
            
        }

        public IEnumerable<string> GetNomiSettori()
        {
            return Settori.Keys;
        } 

        public ISettore GetSettore(string name)
        {
            return Settori[name];
        }

        public IEnumerable<TurnoItem> GetTurni(DateTime inizio,DateTime fine)
        {
            List<TurnoItem> turni = new List<TurnoItem>();

            TimeSpan turno = new TimeSpan(0);
            long tot = 0;
            foreach(ISettore settore in Settori.Values)
            {
               TurnoItem turnoItem = new TurnoItem();
                turnoItem.Attesa = turno;
                double portata = settore.GetPortataVolumetricaSecondo(Cisterna.Portata)/1000;
                long durata = (long)(settore.GetFabisogno(inizio,fine) / portata);
                double mom=settore.GetFabisogno(inizio, fine);
                tot += durata;
                TimeSpan dur = new TimeSpan(durata*TimeSpan.TicksPerSecond+1);
                turnoItem.Durata = dur;
                turnoItem.AddOpenClose(settore.ValvolaSettore);
                turni.Add(turnoItem);
                turno = turno.Add(new TimeSpan(durata*TimeSpan.TicksPerSecond+1));
            }
            TurnoItem itemTurno = new TurnoItem();
            itemTurno.Attesa = new TimeSpan(0);
            itemTurno.Durata = new TimeSpan(tot*TimeSpan.TicksPerSecond);
            turni.Add(itemTurno);

            return turni;
        }

        public bool AddSettore(ISettore settore)
        {
            if (Settori.ContainsKey(settore.Nome))
                return false;
            settore.SettoreUpdated += InvocaOnChanged;
            Settori.Add(settore.Nome, settore);
            OnChanged();
            return true;
        }

        private void InvocaOnChanged(object sender, EventArgs e)
        {
            OnChanged();
        }

        public bool RemoveSettore(string settore)
        {
            if (!Settori.ContainsKey(settore))
                return false;
            Settori.Remove(settore);
            OnChanged();
            return true;
        }

        public void Delete()
        {
            foreach(ISettore settore in Settori.Values)
            {
                settore.Delete();
            }
        }

        public ICisterna Cisterna
        {
            get { return _cisterna; }
            set
            {
                _cisterna = value;
                OnChanged();
            }
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
