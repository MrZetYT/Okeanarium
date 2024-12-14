using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Aquarium : IAquarium
    {
        private readonly ContactInformation contactInformation;
        private readonly List<Fish> fishList = new List<Fish>();
        private readonly List<Plant> plantList = new List<Plant>();
        public Aquarium(ContactInformation contactInformation) => this.contactInformation = contactInformation;
        public ContactInformation ContactInformation { get => contactInformation; }
        public List<Fish> FishList { get => fishList; }
        public List<Plant> PlantList {  get => plantList; }
        public void AddFish(Fish fish)
        {
            FishList.Add(fish);
        }
        public void RemoveFish(int fish)
        {
            FishList.RemoveAt(fishList.Count-1);
        }
        public void AddPlant(Plant plant)
        {
            PlantList.Add(plant);
        }
        public void RemovePlant(int plant)
        {
            PlantList.RemoveAt(plantList.Count-1);
        }

    }
}
