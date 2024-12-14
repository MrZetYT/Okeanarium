using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Fish : IFish
    {
        private readonly ContactInformation contactInformation;
        private double health = 100;
        private double satiety = 85;
        private string fishType = "";
        private double size = 10;
        public virtual string Speak() => "Sound";
        public Fish(ContactInformation contactInformation) => this.contactInformation = contactInformation;
        public double Health { get => health; set => health = value; }
        public double Satiety {  get => satiety; set => satiety = value; }
        public string FishType {  get => fishType; set => fishType = value; }
        public double Size { get => size; set => size = value; }
        public void EatFeed(Feed feed)
        {
            SatietyUp(feed.Satiety);
            HealthDown(feed.HealthGrowth);
        }
        public ContactInformation ContactInformation { get => contactInformation;}
        public void HealthUp(double health) => Health *= 1 + health / 100;
        public void HealthDown(double health) => Health *= 1 - health / 100;
        public void SatietyUp(double satiety) => Satiety *= 1+ satiety / 100;
        public void SatietyDown(double satiety) => Satiety*=1- satiety / 100;
    }
}
