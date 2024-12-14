using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Shark : Fish
    {
        public Shark(ContactInformation contactInformation) : base(contactInformation)
        {
            FishType = "Shark";
            Size = 40;
        }
        public override string Speak() => "Hrrr";
    }
}
