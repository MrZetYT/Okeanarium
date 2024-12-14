using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    public class Cashier : Worker, ICashier
    {
        public Cashier(ContactInformation contactInformation) : base(contactInformation)
        {
            Post = "Cashier";
        }
        public void SellTicket(Visitor visitor, Ticket ticket)
        {
            visitor.AddTicket(ticket);
        }
    }
}
