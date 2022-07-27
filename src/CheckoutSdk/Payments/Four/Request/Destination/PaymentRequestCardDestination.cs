using Checkout.Common.Four;

namespace Checkout.Payments.Four.Request.Destination
{
    public class PaymentRequestCardDestination : PaymentRequestDestination
    {
        public PaymentRequestCardDestination() : base(PaymentDestinationType.Card)
        {
        }

        public string Number { get; set; }

        public int? ExpiryMonth { get; set; }

        public int? ExpiryYear { get; set; }

        public AccountHolder AccountHolder { get; set; }
    }
}