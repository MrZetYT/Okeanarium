using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Ticket : ITicket
    {
        private readonly string ticketName;
        private const int ticketPrice = 10;
        public string TicketName { get => ticketName; }
        public int TicketPrice { get => ticketPrice; }
        public Ticket(string okeanariumName) => ticketName = okeanariumName;
    }
}
