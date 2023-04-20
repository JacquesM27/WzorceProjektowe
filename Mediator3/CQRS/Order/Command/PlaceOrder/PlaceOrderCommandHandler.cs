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

        public Task<PlaceOrderResult> Handle(PlaceOrderCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
