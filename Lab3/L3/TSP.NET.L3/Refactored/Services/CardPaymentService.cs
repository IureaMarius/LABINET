using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.NET.L3.Refactored.DataObjects.Interfaces;

namespace TSP.NET.L3.Refactored.Services
{
    public class CardPaymentService: ICardPaymentService
    {
        IPaymentProcessingGateway _paymentProcessingGateway;
        public CardPaymentService(IPaymentProcessingGateway paymentProcessingGateway)
        {
            this._paymentProcessingGateway = paymentProcessingGateway;
        }
        public void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price, payment);
        }
    }
}
