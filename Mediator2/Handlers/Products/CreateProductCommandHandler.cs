using Mediator2.Data;
using Mediator2.Data.Entities;
using Microsoft.EntityFrameworkCore;
using SimpleSoft.Mediator;

namespace Mediator2.Handlers.Products
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        private readonly AppDbContext _dbContext;
        public CreateProductCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateProductResult> HandleAsync(CreateProductCommand cmd, CancellationToken ct)
        {
            var products = _dbContext.Set<ProductEntity>();

            if (await products.AnyAsync(c => c.Code == cmd.Code, ct))
            {
                throw new InvalidOperationException($"Product with code '{cmd.Code}' already exists");
            }

            var externalId = Guid.NewGuid();
            await products.AddAsync(new ProductEntity
            {
                ExternalId = externalId,
                Code = cmd.Code,
                Name = cmd.Name,
                Price = cmd.Price
            }, ct);

            await _dbContext.SaveChangesAsync(ct);

            return new CreateProductResult { Id = externalId };
        }
    }
}
