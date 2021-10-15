using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L3.Refactored.DataObjects.Interfaces
{
    public interface ICashPaymentService
    {
        void AcceptCash(TicketDetails ticket);
        void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone);
    }
}
