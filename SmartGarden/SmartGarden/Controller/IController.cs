using System.Windows.Forms;
using SmartGarden.Model;
using SmartGarden.View;

namespace SmartGarden.Control
{
    interface IController
    {
        bool CreateLoginForm();
        void CambiaProvincia(string provincia);
        void CaricaProvinceComboBox(ComboBox provinceComboBox);
        void CaricaInfoGiardino();
        void SettaTimer();
        void GestisciSettori();
        void NuovoGiardino();
        void GestioneInfoPiantaView(IPianta pianta);
        void CreaSettore(string nomeSettore, double portataImpianto, Valvola valvola);
        void CancellaSettore(string nomeSettore);
        void GestisciTimer();
        void GestisciCisterna();
        void CreaNuovaCisterna(double portata, double capacità);
        void CreaNuovaPianta(string nomeBotanico, string nomeComune, double area, string nomeSettore, FabbisognoGiornalieroPeriodo fabbisognoPeriodo);
        void CaricaViewPiante(string nomeSettore, Form settoriForm = null);
        void CancellaPianta(IPianta pianta, ISettore settore);
    }
}
