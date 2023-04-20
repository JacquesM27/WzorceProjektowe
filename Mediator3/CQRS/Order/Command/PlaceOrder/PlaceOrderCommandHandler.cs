using Mediator3.CQRS.Order.Command.ProcessPayment;
using Mediator3.CQRS.Order.Command.ShipOrder;
using Mediator3.DTO;
using Mediator3.Mediator;

namespace Mediator3.CQRS.Order.Command.PlaceOrder
{
    public class PlaceOrderCommandHandler : IRequestHandler<PlaceOrderCommand, PlaceOrderResult>
    {
        private readonly IMediator _mediator;

        public PlaceOrderCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<PlaceOrderResult> Handle(PlaceOrderCommand request)
        {
            var paymentResult = await _mediator.Send(new ProcessPaymentCommand
            {
                OrderId = request.OrderId,
                CustomerId = request.CustomerId,
                TotalAmount = request.Items.Sum(c => c.Quantity * c.Price),
            });

            if (!paymentResult.Success) 
            {
                throw new Exception("Error while processing payment.");
            }

            var shippingResult = await _mediator.Send(new ShipOrderCommand
            {
                OrderId = request.OrderId,
                CustomerId = request.CustomerId,
                Items = request.Items,
            });
            return new PlaceOrderResult { Success = paymentResult.Success };
        }
    }
}
