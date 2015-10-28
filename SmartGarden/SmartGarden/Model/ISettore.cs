using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    public interface ISettore
    {
        bool AddPianta(IPianta pianta);

        bool RemovePianta(IPianta pianta);

        bool HasPianta(IPianta pianta);

        IPianta GetPianta(Guid guid);

        double GetFabisogno(DateTime inizio, DateTime fine);

        double GetPortataVolumetricaSecondo(double portata);

        double PortataImpianto { get; set; }

        IOpenClose ValvolaSettore { get; set; }

        String Nome { get; }

        void Delete();

        IEnumerable<Guid> GetGuidPiante();

        event EventHandler SettoreUpdated;
    }
}
