using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Okeanarium : IOkeanarium
    {
        private readonly ContactInformation contactInformation;
        private List<Aquarium> aquariumList=new List<Aquarium>();
        public Okeanarium(ContactInformation contactInformation) => this.contactInformation = contactInformation;
        public ContactInformation ContactInformation => contactInformation;
        public List<Aquarium> AquariumList { get =>  aquariumList;}
        public void AddAquarium(Aquarium aquarium)
        {
            aquariumList.Add(aquarium);
        }
        public void RemoveAquarium(int aquariumID) 
        {
            aquariumList.RemoveAt(aquariumList.Count-1);
        }
    }
}
