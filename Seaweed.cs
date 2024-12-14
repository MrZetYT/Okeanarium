using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Seaweed : Plant
    {
        public Seaweed(ContactInformation contactInformationPlant) : base(contactInformationPlant)
        {
            Size = 50;
            GrowingDegree = 10;
            Color = "Dark Green";
            PlantType = "Seaweed";
        }
    }
}
