using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    interface ISettore
    {
        bool AddPianta(IPianta pianta);

        bool RemovePianta(IPianta pianta);

        bool HasPianta(IPianta pianta);

        IPianta GetPianta(Guid guid);

        double GetFabisogno(DateTime inizio, DateTime fine);

        double GetPortataVolumetricaSecondo(double portata);

        double PortataImpianto { get; set; }

        IOpenClose _valvolaSettore { get; set; }

        String Nome { get; }

        IEnumerable<Guid> GetGuidPiante();
    }
}
