using Mediator2.Data;
using Mediator2.Data.Entities;
using Mediator2.Model;
using Microsoft.EntityFrameworkCore;
using SimpleSoft.Mediator;

namespace Mediator2.Handlers.Products
{
    public class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, Product>
    {
        private readonly IQueryable<ProductEntity> _products;

        public GetProductByIdQueryHandler(AppDbContext dbContext)
        {
            _products = dbContext.Set<ProductEntity>();
        }

        public async Task<Product> HandleAsync(GetProductByIdQuery query, CancellationToken ct)
        {
            var product = await _products.SingleOrDefaultAsync(c => c.ExternalId == query.ProductId, ct);
            if (product is null)
            {
                throw new InvalidOperationException($"Product with id '{query.ProductId}' not found");
            }

            return new Product
            {
                Id = product.ExternalId,
                Code = product.Code,
                Name = product.Name,
                Price = product.Price
            };
        }
    }
}
