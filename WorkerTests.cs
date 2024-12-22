using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium.Tests
{
    public class WorkerTests
    {
        [Test]
        public void Worker_GetPost_1()
        {
            ContactInformation information = new("Volodya");
            Worker worker = new(information);
            worker.Post = "Washer";
            Assert.That(worker.Post, Is.EqualTo("Washer"));
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
    }
}
