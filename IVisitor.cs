using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface IVisitor
    {
        ContactInformation ContactInformation { get; }
        List<Ticket> TicketList { get; }
        void AddTicket(Ticket ticket);
        void RemoveTicket(string ticketName);
        List<Aquarium> VisitOkeanarium(Okeanarium okeanarium, Ticket ticket);
    }
}
