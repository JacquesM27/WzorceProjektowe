using Mediator3.DTO;
using Mediator3.Mediator;

namespace Mediator3.CQRS.Order.Command.ShipOrder
{
    public class ShipOrderCommandHandler : IRequestHandler<ShipOrderCommand, ShipOrderResult>
    {
        public Task<ShipOrderResult> Handle(ShipOrderCommand request)
        {
            //brr...
            return new PaymentResult { Success = true };
        }
    }
}
