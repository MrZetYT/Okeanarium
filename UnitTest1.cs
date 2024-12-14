using System.Net.Sockets;
using System.Numerics;
using System.Runtime.Intrinsics;
using Okeanarium;

namespace Okeanarium.Tests
{
    public class Tests
    {

        [Test]
        public void Okeanarium_GetContact_1()
        {
            Ticket ticket = new("Luzha");
            int ticketNumber = 5;
            List<Feed> storage_food;
            ContactInformation okeanariumInformation = new("Luzha");
            Okeanarium okeanarium = new(okeanariumInformation);
            Assert.That(okeanarium.ContactInformation.Name, Is.EqualTo(okeanariumInformation.Name));
        }
        [Test]
        public void Okeanarium_GetContact_2()
        {
            Ticket ticket = new("Luzha");
            int ticketNumber = 5;
            List<Feed> storage_food;
            ContactInformation okeanariumInformation = new("Luzha");
            Okeanarium okeanarium = new(okeanariumInformation);
            Assert.That(okeanarium.ContactInformation.ID, Is.EqualTo(okeanariumInformation.ID));
        }
        [Test]
        public void Okeanarium_GetAquariumList_1()
        {
            Ticket ticket=new("Luzha");
            int ticketNumber = 5;
            List<Feed> storage_food;
            ContactInformation okeanariumInformation=new("Luzha");
            Okeanarium okeanarium=new(okeanariumInformation);
            ContactInformation aquariumInformation1=new ("Water_World");
            Aquarium aquarium1=new(aquariumInformation1);
            ContactInformation aquariumInformation2=new("World_for_swim");
            Aquarium aquarium2=new(aquariumInformation2);
            okeanarium.AddAquarium(aquarium1);
            okeanarium.AddAquarium(aquarium2);
            okeanarium.RemoveAquarium(aquarium1.ContactInformation.ID);
            Assert.That(okeanarium.AquariumList.Count, Is.EqualTo(1));
        }

        [Test]
        public void Okeanarium_GetWorkerList_1()
        {
            Ticket ticket = new("Luzha");
            int ticketNumber = 5;
            List<Feed> storage_food;
            ContactInformation okeanariumInformation = new("Luzha");
            Okeanarium okeanarium = new(okeanariumInformation);
            ContactInformation workerInformation1=new("Marat");
            Worker worker1=new(workerInformation1);
            ContactInformation workerInformation2=new("Maryanna");
            Worker worker2 =new(workerInformation2);
            List<Worker> workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);
            Assert.That(workers.Count, Is.EqualTo(2));
        }
        [Test]
        public void Fish_GetContactInformation_1()
        {
            ContactInformation information = new("Catty");
            Fish fish = new (information);
            Assert.That(fish.ContactInformation, Is.EqualTo(information));
        }
        [Test]
        public void Fish_GetHealth_1()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
            fish.Health = 30;
            Assert.That(fish.Health, Is.EqualTo(30));
        }
        [Test]
        public void Fish_GetSatiety_1()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
            fish.Satiety = 99;
            Assert.That(fish.Satiety, Is.EqualTo(99));
        }
        [Test]
        public void Fish_GetFishType_1()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
            fish.FishType = "Cat";
            Assert.That(fish.FishType, Is.EqualTo("Cat"));
        }
        [Test]
        public void Fish_GetSpeak_1()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
            Assert.That(fish.Speak(), Is.EqualTo("Sound"));
        }
        [Test]
        public void Fish_EatFeed_1()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
            ContactInformation info = new("Feed");
            Feed feed = new(info, 77, 66);
            fish.EatFeed(feed);
            Assert.That(fish.Health, Is.EqualTo(100-77));
        }
        [Test]
        public void Fish_EatFeed_2()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
            ContactInformation info = new("Feed");
            Feed feed = new(info, 77, 66);
            fish.EatFeed(feed);
            Assert.That(fish.Satiety, Is.EqualTo(1.66*85.00000000000001));
        }
        [Test]
        public void Worker_GetPost_1()
        {
            ContactInformation information = new("Volodya");
            Worker worker= new(information);
            worker.Post= "Washer";
            Assert.That(worker.Post, Is.EqualTo("Washer"));
        }
        [Test]
        public void Aquarium_GetAnimalList_1()
        {
            ContactInformation information1 = new("Timon");
            ContactInformation information2 = new("Pumba");
            ContactInformation information3 = new("Simba");
            Fish fish1 = new(information1);
            Fish fish2 = new(information2);
            Fish fish3 = new(information3);
            ContactInformation aquariumInformation=new("Water");
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
        [Test]
        public void Worker_FeedFeed_1()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
            ContactInformation info = new("Feed");
            Feed feed = new(info, 77, 66);
            ContactInformation info2 = new ContactInformation("Vova");
            Worker worker = new Worker(info2);
            worker.FeedFish(fish, feed);
            Assert.That(fish.Satiety, Is.EqualTo(1.66 * 85.00000000000001));
        }
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
        [Test]
        public void Seagrass_GetType_1()
        {
            ContactInformation information = new("Seagrass");
            Seagrass seagrass = new(information);
            Assert.That(seagrass.PlantType, Is.EqualTo("Seagrass"));
        }
        [Test]
        public void Coral_GetType_1()
        {
            ContactInformation information = new("Coral");
            Coral coral = new(information);
            Assert.That(coral.PlantType, Is.EqualTo("Coral"));
        }
        [Test]
        public void Seaweed_GetType_1()
        {
            ContactInformation information = new("Seaweed");
            Seaweed seaweed = new(information);
            Assert.That(seaweed.PlantType, Is.EqualTo("Seaweed"));
        }
        [Test]
        public void Dolphin_GetSound_1()
        {
            ContactInformation information = new("Dormin");
            Dolphin dolphin = new(information);
            Assert.That(dolphin.Speak(), Is.EqualTo("E E E"));
        }
        [Test]
        public void Shark_GetSound_1()
        {
            ContactInformation information = new("Dormini");
            Shark shark = new(information);
            Assert.That(shark.Speak(), Is.EqualTo("Hrrr"));
        }
        [Test]
        public void FuguFish_GetSound_1()
        {
            ContactInformation information = new("Dorminini");
            FuguFish fuguFish = new(information);
            Assert.That(fuguFish.Speak(), Is.EqualTo("Fsh Fsh Fsh"));
        }
        [Test]
        public void Cashire_SellTicket_1()
        {
            ContactInformation information1 = new("Matt");
            ContactInformation information2 = new("Steve");
            Cashier cashier = new Cashier(information1);
            Visitor visitor = new Visitor(information2);
            Ticket ticket = new("Boloto");
            cashier.SellTicket(visitor, ticket);
            Assert.That(visitor.TicketList.Count, Is.EqualTo(1));
        }
        [Test]
        public void Visitor_GetContactInformation_1()
        {
            ContactInformation information1 = new("Matt");
            Visitor visitor = new (information1);
            Assert.That(visitor.ContactInformation, Is.EqualTo(information1));
        }
    }
}