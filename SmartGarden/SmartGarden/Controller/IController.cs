using System.Windows.Forms;

namespace SmartGarden.Controller
{
    public interface IController
    {
        bool CreateLoginForm();
        void CaricaViewPiante(string nomeSettore);
        void CambiaProvincia(string provincia);
        void CaricaProvinceComboBox(ComboBox provinceComboBox);
        void CaricaInfoGiardino();
        void SettaTimer();
        void GestisciSettori();
        void NuovoGiardino();
    }
}
