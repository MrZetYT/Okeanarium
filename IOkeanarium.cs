using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface IOkeanarium
    {
        ContactInformation ContactInformation { get; }
        List<Aquarium> AquariumList { get; }
        void AddAquarium(Aquarium aquarium);
        void RemoveAquarium(int aquariumID);
    }
}
