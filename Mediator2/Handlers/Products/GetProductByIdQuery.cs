using Mediator2.Model;
using SimpleSoft.Mediator;

namespace Mediator2.Handlers.Products
{
    public class GetProductByIdQuery : Query<Product>
    {
        public Guid ProductId { get; set; }
    }
}
