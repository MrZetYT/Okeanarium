using System.Net.Sockets;
using System.Numerics;
using System.Runtime.Intrinsics;
using Okeanarium;

namespace Okeanarium.Tests
{
    public class OtherTests
    {
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