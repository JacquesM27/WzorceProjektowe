using Mediator2.Data;
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

        public Task<CreateProductResult> HandleAsync(CreateProductCommand cmd, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
