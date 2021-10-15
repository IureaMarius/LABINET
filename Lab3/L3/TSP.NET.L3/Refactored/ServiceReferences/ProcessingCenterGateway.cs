using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.NET.L3.Refactored.DataObjects.Interfaces;

namespace TSP.NET.L3.Refactored.ServiceReferences
{
    public class ProcessingCenterGateway: IPaymentProcessingGateway
    {
        public void Charge(decimal ticketPrice, PaymentDetails paymentDetails)
        {
            //charging process
        }
    }
}
