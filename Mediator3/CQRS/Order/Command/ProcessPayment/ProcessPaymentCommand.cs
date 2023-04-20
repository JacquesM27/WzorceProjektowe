using Mediator3.DTO;
using Mediator3.Mediator;

namespace Mediator3.CQRS.Order.Command.ProcessPayment
{
    public class ProcessPaymentCommand : IRequest<PaymentResult>
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
