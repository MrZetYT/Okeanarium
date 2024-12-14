using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface IFeed
    {
        ContactInformation ContactInformation { get; }
        double Satiety { get; }
        double HealthGrowth { get; }
    }
}
