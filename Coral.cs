using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Coral : Plant
    {
        public Coral(ContactInformation contactInformationPlant) :base(contactInformationPlant)
        {
            Size = 20;
            GrowingDegree = 5;
            Color = "Ruby";
            PlantType = "Coral";
        }
    }
}
