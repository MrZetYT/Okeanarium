using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium.Tests
{
    public class PlantTests
    {
        [Test]
        public void Plant_GetSize_1()
        {
            ContactInformation information = new("Rose");
            Plant plant = new(information);
            plant.Size = 200;
            Assert.That(plant.Size, Is.EqualTo(200));
        }
        [Test]
        public void Plant_GetGrowingDegree_1()
        {
            ContactInformation information = new("Rose");
            Plant plant = new(information);
            plant.GrowingDegree = 200;
            Assert.That(plant.GrowingDegree, Is.EqualTo(200));
        }
        [Test]
        public void Plant_GetColor_1()
        {
            ContactInformation information = new("Rose");
            Plant plant = new(information);
            plant.Color = "Blue";
            Assert.That(plant.Color, Is.EqualTo("Blue"));
        }
        [Test]
        public void Plant_GetPlantType_1()
        {
            ContactInformation information = new("Rose");
            Plant plant = new(information);
            plant.PlantType = "Plant";
            Assert.That(plant.PlantType, Is.EqualTo("Plant"));
        }
        [Test]
        public void Plant_GetGrowth_1()
        {
            ContactInformation information = new("Rose");
            Plant plant = new(information);
            plant.GrowingDegree = 20;
            plant.Size = 10;
            plant.Growth();
            Assert.That(plant.Size, Is.EqualTo(200));
        }
        [Test]
        public void Plant_GetDownsize_1()
        {
            ContactInformation information = new("Rose");
            Plant plant = new(information);
            plant.Size = 10;
            plant.Downsize(10);
            Assert.That(plant.Size, Is.EqualTo(100));
        }
    }
}
