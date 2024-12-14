using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class ContactInformation: IContactInformation
    {
        private readonly string name;
        private static int id;
        public ContactInformation(string name)
        {
            this.name = name;
            id = GenerateID();
        }
        private int GenerateID()
        {
            return ++id;
        }
        public int ID { get => id; }
        public string Name { get => name; }
    }
}
