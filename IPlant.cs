using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface IPlant
    {
        ContactInformation ContactInformation { get; }
        double Size { get; set; }
        string PlantType {  get; set; }
        string Color { get; set; }
        double GrowingDegree {  get; set; }
        void Growth();
        void Downsize(double downsize);

    }
}
