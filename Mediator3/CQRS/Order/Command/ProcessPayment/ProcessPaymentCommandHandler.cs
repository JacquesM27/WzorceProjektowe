using Mediator3.DTO;
using Mediator3.Mediator;

namespace Mediator3.CQRS.Order.Command.ProcessPayment
{
    public class ProcessPaymentCommandHandler : IRequestHandler<ProcessPaymentCommand, PaymentResult>
    {
        public async Task<PaymentResult> Handle(ProcessPaymentCommand request)
        {
            //brr...
            return  new PaymentResult { Success = true };
        }
    }
}
