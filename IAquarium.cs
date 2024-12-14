using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface IAquarium
    {
        ContactInformation ContactInformation { get; }
        List<Fish> FishList { get; }
        void AddFish(Fish fish);
        void RemoveFish(int fishID);
        List<Plant> PlantList { get; }
        void RemovePlant(int plantID);
        void AddPlant(Plant plant);
    }
}
