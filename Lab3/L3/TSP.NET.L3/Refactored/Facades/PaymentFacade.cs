using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.NET.L3.Refactored.DataObjects.Interfaces;

namespace TSP.NET.L3.Refactored.Facades
{
    public class PaymentFacade
    {
        private ICardPaymentService _cardPaymentService;
        private ICashPaymentService _cashPaymentService;
        public PaymentFacade(ICardPaymentService cardPaymentService, ICashPaymentService cashPaymentService)
        {
            this._cardPaymentService = cardPaymentService;
            this._cashPaymentService = cashPaymentService;
        }

        public void BuyTicket(TicketDetails ticket,
                              PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            if (payment.Method == PaymentMethod.CreditCard)
            {
                this._cardPaymentService.ChargeCard(ticket, payment);
            }
            else
            {
                this._cashPaymentService.AcceptCash(ticket);
                this._cashPaymentService.DispenseChange(ticket, onPayChangeToMobilePhone);
            }
        }
    }
}
