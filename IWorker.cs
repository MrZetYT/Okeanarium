using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface IWorker
    {
        ContactInformation ContactInformationWorker { get; }
        string Post { get; set; }
        void FeedFish(Fish fish, Feed feed);
    }
}
