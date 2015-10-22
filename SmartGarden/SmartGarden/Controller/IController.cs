using System.Windows.Forms;
using SmartGarden.Model;

namespace SmartGarden.Control
{
    interface IController
    {
        bool CreateLoginForm();
        void CaricaViewPiante(string nomeSettore);
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
        void CancellaPianta(IPianta pianta, ISettore settore);
    }
}
