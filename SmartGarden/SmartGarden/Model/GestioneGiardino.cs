using System;
using System.Timers;

namespace SmartGarden.Model
{
    public class GestioneGiardino : IGestioneGiardinoData,IGestioneGiardino
    {
        private IGiardino _giardino;
        private string _luogo;
        private MyTimer _timers;
        private static GestioneGiardino _instance = null;
        private DateTime _oraInizioInnaffiatura;
        private TimeSpan _intervallo;

        public event EventHandler Changed;

        public DateTime OraInizioInnaffiatura
        {
            get { return _oraInizioInnaffiatura; }
        }
        public TimeSpan Intervallo
        {
            get { return _intervallo; }
        }
        private GestioneGiardino()
        {
            _timers = MyTimer.GetMyTimer();
            _oraInizioInnaffiatura = DateTime.Now;
            TimeSpan ts;
            if(OraInizioInnaffiatura.Hour>=19)
            {
                ts = new TimeSpan(1, 19, 0, 0);
            }
            else
            {
                ts = new TimeSpan(19, 0, 0);
            }
            _oraInizioInnaffiatura = OraInizioInnaffiatura.Date + ts;
            _intervallo = new TimeSpan(1, 0, 0, 0);
            _timers.SetTimerPrincipale(OraInizioInnaffiatura, Intervallo,IniziaInnaffiatura);
            //TODO da togliere
            DateTime now = DateTime.Now.AddSeconds(5);
            _timers.SetTimerPrincipale(now, Intervallo, IniziaInnaffiatura);
        }

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty); //aggiorna la view
        }

        public IGiardino Giardino
        {
            get { return _giardino; }
            set
            {
                _giardino = value;
                OnChanged();
            }
        }

        public string Luogo
        {
            get { return _luogo; }
            set
            {
                _luogo = value;
                OnChanged();
            }
        }

        public static GestioneGiardino GetGestoreGiardino()
        {
            if(_instance==null)
            {
                _instance = new GestioneGiardino();
            }
            return _instance;
        }

        public void SetTimer(DateTime date,TimeSpan intervallo)
        {
            _oraInizioInnaffiatura = date;
            _intervallo = intervallo;
            _timers.SetTimerPrincipale(date, intervallo,IniziaInnaffiatura);
        }

        public static IGestioneGiardinoData GetData()
        {
            return _instance ;
        }

        private void IniziaInnaffiatura(Object source, ElapsedEventArgs e)
        {
            IniziaInnaffiatura(_oraInizioInnaffiatura,_oraInizioInnaffiatura.Date+Intervallo);
        }

        private void IniziaInnaffiatura(DateTime inizio ,DateTime fine)
        {
            foreach(TurnoItem turno in Giardino.GetTurni(inizio,fine))
            {
                foreach(IOpenClose openclose in turno.Mehtods)
                _timers.SetTimers(turno.Attesa, turno.Durata,openclose);
            }
        } 

    }
}