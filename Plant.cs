using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Plant : IPlant
    {
        private readonly ContactInformation contactInformation;
        private double size = 0;
        private double growingDegree = 0;
        private string color = "";
        private string plantType = "";
        
        public Plant(ContactInformation contactInformationPlant) { contactInformation = contactInformationPlant; }
        public double Size { get => size; set => size = value; }
        public double GrowingDegree { get => growingDegree; set => growingDegree = value; }
        public string Color { get => color; set => color = value; }
        public string PlantType { get => plantType; set => plantType = value; }
        public void Growth() => Size *= (growingDegree +10 / 100);
        public void Downsize(double downsize) => Size *= (downsize - 10 / 100); 
        public ContactInformation ContactInformation { get => contactInformation;}
    }
}
