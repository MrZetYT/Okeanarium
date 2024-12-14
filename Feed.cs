using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Feed : IFeed
    {
        private readonly ContactInformation contactInformation;
        private readonly double healthGrowth;
        private readonly double satiety;
        public Feed(ContactInformation contactInformation, double healthGrowth, double satiety)
        {
            this.contactInformation = contactInformation;
            this.healthGrowth = healthGrowth;
            this.satiety = satiety;
        }
        public ContactInformation ContactInformation { get =>contactInformation; }
        public double HealthGrowth {  get => healthGrowth; }
        public double Satiety {  get => satiety; }
    }
}
