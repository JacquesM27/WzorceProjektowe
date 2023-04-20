using Mediator3.CQRS.Order.Command.PlaceOrder;
using Mediator3.Mediator;
using Mediator3.Model;
using Microsoft.AspNetCore.Mvc;

namespace Mediator3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> PlaceOrder(Order order)
        {
            var result = await _mediator.Send(new PlaceOrderCommand
            {
                OrderId = order.OrderId,
                CustomerId = order.CustomerId,
                Items = order.Items,
            });
            if(result.Success)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
