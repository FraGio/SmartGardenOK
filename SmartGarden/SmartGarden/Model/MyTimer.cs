using System;
using System.Collections.Generic;
using System.Timers;

namespace SmartGarden.Model
{
    class MyTimer
    {
        //TODO mettere a posto il timer
        private Dictionary<DateTime, MyInternalTimer> _timers;
        private MyInternalTimer _timerPrincipale ;
        private TimeSpan _intervalloPrincipale;
        private static MyTimer instance = null;

        public static MyTimer GetMyTimer()
        {
            if (instance == null)
                instance = new MyTimer();
            return instance;
        }

        private MyTimer()
        {
            _timerPrincipale = new MyInternalTimer();
            _timers = new Dictionary<DateTime, MyInternalTimer>();
            _intervalloPrincipale = new TimeSpan(1, 0, 0, 0);
        }


        public bool SetTimers(DateTime inizio, TimeSpan durata,IOpenClose handlers)
        {
            DateTime fine = inizio + durata;
            return SetTimers(inizio, fine, handlers);
        }

        public bool SetTimers(DateTime inizio,DateTime fine,IOpenClose handlers)
        {
            #region timer apertura
            SetTimer(inizio, handlers.Open);
            #endregion

            #region timer chiusura
            SetTimer(fine, handlers.Close);
            #endregion

            return true;
        }

        public bool SetTimer(DateTime data,ElapsedEventHandler ev)
        {
            if (!_timers.ContainsKey(data))
            {
                MyInternalTimer timerApertura = new MyInternalTimer(data.Millisecond);
                _timers.Add(data, timerApertura);
            }
            _timers[data].AddEventHandler(ev);

            return true;
        }

        public bool SetTimerPrincipale(DateTime data,TimeSpan intervallo)
        {
            _intervalloPrincipale = intervallo;
            #region deregistro
            foreach (MyInternalTimer timer in _timers.Values)
            {
                _timerPrincipale.RemoveEventHandler(timer.Start);
            }
            _timerPrincipale.RemoveEventHandler(SetNextIntervalloPrincipale);
            _timerPrincipale = new MyInternalTimer(data.Millisecond);
            #endregion

            #region registro
            foreach (MyInternalTimer timer in _timers.Values)
            {
                _timerPrincipale.AddEventHandler(timer.Start);
            }
            _timerPrincipale.AddEventHandler(SetNextIntervalloPrincipale);
            #endregion
            return true;
        }

        private void SetNextIntervalloPrincipale(Object source, ElapsedEventArgs e)
        {
            DateTime next = DateTime.Now + _intervalloPrincipale;
            SetTimerPrincipale(next, _intervalloPrincipale);
        }

        private class MyInternalTimer
        {
            Timer timer;

            public MyInternalTimer(long mills=0)
            {
                timer = new Timer(mills);
            }

            public void SetTimer(long mills)
            {
                timer = new Timer(mills);
            }

            public void AddEventHandler(ElapsedEventHandler ev)
            {
                timer.Elapsed += ev;
            }

            public void RemoveEventHandler(ElapsedEventHandler ev)
            {
                timer.Elapsed -= ev;
            }

            public void Start(Object source, ElapsedEventArgs e)
            {
                timer.Start();
            }
        }
    }
}