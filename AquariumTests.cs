using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium.Tests
{
    public class AquariumTests
    {
        [Test]
        public void Aquarium_GetAnimalList_1()
        {
            ContactInformation information1 = new("Timon");
            ContactInformation information2 = new("Pumba");
            ContactInformation information3 = new("Simba");
            Fish fish1 = new(information1);
            Fish fish2 = new(information2);
            Fish fish3 = new(information3);
            ContactInformation aquariumInformation = new("Water");
            Aquarium aquarium = new(aquariumInformation);
            aquarium.AddFish(fish1);
            aquarium.AddFish(fish2);
            aquarium.AddFish(fish3);
            aquarium.RemoveFish(fish1.ContactInformation.ID);
            Assert.That(aquarium.FishList.Count, Is.EqualTo(2));
        }
        [Test]
        public void Aquarium_GetPlantList_1()
        {
            ContactInformation information1 = new("Semecvet");
            ContactInformation information2 = new("Romashka");
            ContactInformation information3 = new("Rose");
            Plant plant1 = new(information1);
            Plant plant2 = new(information2);
            Plant plant3 = new(information3);
            ContactInformation aquariumInformation = new("Water");
            Aquarium aquarium = new(aquariumInformation);
            aquarium.AddPlant(plant1);
            aquarium.AddPlant(plant2);
            aquarium.AddPlant(plant3);
            aquarium.RemovePlant(plant1.ContactInformation.ID);
            Assert.That(aquarium.PlantList.Count, Is.EqualTo(2));
        }
    }
}
