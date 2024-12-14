using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Worker : IWorker
    {
        private readonly ContactInformation contactInformation;
        private string post = "";
        public Worker(ContactInformation contactInformationWorker)
        {
            contactInformation = contactInformationWorker;
        }
        public ContactInformation ContactInformationWorker { get => contactInformation; }
        public string Post { get => post; set => post = value; }
        public void FeedFish(Fish fish, Feed feed)
        {
            fish.EatFeed(feed);
        }
    }
}
