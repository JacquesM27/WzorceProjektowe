using Mediator3.DTO;
using Mediator3.Mediator;
using Mediator3.Model;

namespace Mediator3.CQRS.Order.Command.PlaceOrder
{
    public class PlaceOrderCommand : IRequest<PlaceOrderResult>
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
