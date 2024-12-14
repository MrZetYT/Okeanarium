using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface IFish
    {
        ContactInformation ContactInformation { get; }
        double Health { get; set; }
        double Satiety { get; set; }
        string FishType { get; set; }
        double Size {  get; set; }
        void EatFeed(Feed feed);
        void HealthUp(double health);
        void HealthDown(double health);
        void SatietyUp(double satiety);
        void SatietyDown(double satiety);

    }
}
