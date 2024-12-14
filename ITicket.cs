using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okeanarium
{
    internal interface ITicket
    {
        string TicketName { get; }
        int TicketPrice { get; }
    }
}
