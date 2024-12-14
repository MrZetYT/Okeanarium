using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Visitor : IVisitor
    {
        private readonly ContactInformation contactInformation;
        private readonly List<Ticket> ticketList = new List<Ticket>();
        public Visitor(ContactInformation contactInformation) => this.contactInformation = contactInformation;
        public ContactInformation ContactInformation { get => contactInformation; }
        public List<Ticket> TicketList { get=>ticketList;}
        public void AddTicket(Ticket ticket)
        {
            ticketList.Add(ticket);
        }
        public void RemoveTicket(string ticketName)
        {
            int ticketIndex = SearchTicket(ticketName);
            if( ticketIndex !=-1)
            {
                TicketList.RemoveAt(ticketIndex);
            }
        }
        public List<Aquarium> VisitOkeanarium(Okeanarium okeanarium, Ticket ticket)
        {
            RemoveTicket(ticket.TicketName);
            return okeanarium.AquariumList;
        }
        private int SearchTicket(string ticketName)
        {
            for(int i = 0; i < TicketList.Count; i++)
            {
                if (TicketList[i].TicketName == ticketName) return i;
            }
            return -1;
        }
    }
}
