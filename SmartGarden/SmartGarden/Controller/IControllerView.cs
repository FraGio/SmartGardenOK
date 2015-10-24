using SmartGarden.Control;
using SmartGarden.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden.Controller
{
    interface IControllerView
    {

        void CreaAggiungiPiantaView(string nome, Form parentForm);
        void CreaPianteView(string nomeSettore, Form settoriForm = null);
        void CreaGestisciCisternaView();
        void CreaSettoreView(string nomeSettore, double portataImpianto, Valvola valvola);
        void CreaGestioneInfoPiantaView(IPianta pianta);
        void CreaSettoriView();
        void CreaNotificheView();
        void CreaGestoreFabbisognoPiantaView(IPianta pianta);
        void CreaMeteoView();
    }
}
