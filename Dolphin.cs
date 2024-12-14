using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Dolphin : Fish
    {
        public Dolphin(ContactInformation contactInformation) : base(contactInformation) 
        {
            FishType = "Dolphin"; 
            Size = 30;
        }
        public override string Speak() => "E E E";
    }
}
