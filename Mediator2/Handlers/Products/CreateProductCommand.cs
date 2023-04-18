using SimpleSoft.Mediator;

namespace Mediator2.Handlers.Products
{
    public class CreateProductCommand : Command<CreateProductResult>
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
