using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class FuguFish : Fish
    {
        public FuguFish(ContactInformation contactInformation) : base(contactInformation)
        {
            FishType = "Fugu fish";
            Size = 10;
        }
        public override string Speak() => "Fsh Fsh Fsh";
        public void Pout() => Size *= 2;
    }
}
