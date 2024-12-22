using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium.Tests
{
    public class OkeanariumTests
    {

        [Test]
        public void Okeanarium_GetContact_1()
        {
            Ticket ticket = new("Luzha");
            ContactInformation okeanariumInformation = new("Luzha");
            Okeanarium okeanarium = new(okeanariumInformation);
            Assert.That(okeanarium.ContactInformation.Name, Is.EqualTo(okeanariumInformation.Name));
        }
        [Test]
        public void Okeanarium_GetContact_2()
        {
            Ticket ticket = new("Luzha");
            ContactInformation okeanariumInformation = new("Luzha");
            Okeanarium okeanarium = new(okeanariumInformation);
            Assert.That(okeanarium.ContactInformation.ID, Is.EqualTo(okeanariumInformation.ID));
        }
        [Test]
        public void Okeanarium_GetAquariumList_1()
        {
            Ticket ticket = new("Luzha");
            ContactInformation okeanariumInformation = new("Luzha");
            Okeanarium okeanarium = new(okeanariumInformation);
            ContactInformation aquariumInformation1 = new("Water_World");
            Aquarium aquarium1 = new(aquariumInformation1);
            ContactInformation aquariumInformation2 = new("World_for_swim");
            Aquarium aquarium2 = new(aquariumInformation2);
            okeanarium.AddAquarium(aquarium1);
            okeanarium.AddAquarium(aquarium2);
            okeanarium.RemoveAquarium(aquarium1.ContactInformation.ID);
            Assert.That(okeanarium.AquariumList.Count, Is.EqualTo(1));
        }

        [Test]
        public void Okeanarium_GetWorkerList_1()
        {
            Ticket ticket = new("Luzha");
            ContactInformation okeanariumInformation = new("Luzha");
            Okeanarium okeanarium = new(okeanariumInformation);
            ContactInformation workerInformation1 = new("Marat");
            Worker worker1 = new(workerInformation1);
            ContactInformation workerInformation2 = new("Maryanna");
            Worker worker2 = new(workerInformation2);
            List<Worker> workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);
            Assert.That(workers.Count, Is.EqualTo(2));
        }
    }
}
