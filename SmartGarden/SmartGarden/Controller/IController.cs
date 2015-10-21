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
        void CreaPiantaView(IPianta pianta);
        void CreaSettore(string nomeSettore, double portataImpianto, Valvola valvola);
    }
}
