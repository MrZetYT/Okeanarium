using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface ICashier
    {
        void SellTicket(Visitor visitor, Ticket ticket);
    }
}
