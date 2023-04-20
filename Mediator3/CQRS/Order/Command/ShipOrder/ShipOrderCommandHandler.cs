using Mediator3.DTO;
using Mediator3.Mediator;

namespace Mediator3.CQRS.Order.Command.ShipOrder
{
    public class ShipOrderCommandHandler : IRequestHandler<ShipOrderCommand, ShipOrderResult>
    {
        public async Task<ShipOrderResult> Handle(ShipOrderCommand request)
        {
            //brr...
            return new ShipOrderResult { Success = true };
        }
    }
}
