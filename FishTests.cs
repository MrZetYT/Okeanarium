using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium.Tests
{
    public class FishTests
    {
        [Test]
        public void Fish_GetContactInformation_1()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
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
            Assert.That(fish.Health, Is.EqualTo(100 - 77));
        }
        [Test]
        public void Fish_EatFeed_2()
        {
            ContactInformation information = new("Catty");
            Fish fish = new(information);
            ContactInformation info = new("Feed");
            Feed feed = new(info, 77, 66);
            fish.EatFeed(feed);
            Assert.That(fish.Satiety, Is.EqualTo(1.66 * 85.00000000000001));
        }
    }
}
