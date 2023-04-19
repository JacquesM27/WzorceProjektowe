using Mediator2.Data;
using Mediator2.Data.Entities;
using SimpleSoft.Mediator;
using System.Text.Json;

namespace Mediator2.Handlers.Products
{
    public class CreatedProductEventHandler : IEventHandler<CreatedProductEvent>
    {
        private readonly AppDbContext _dbContext;

        public CreatedProductEventHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task HandleAsync(CreatedProductEvent evt, CancellationToken ct)
        {
            await _dbContext.Set<EventEntity>().AddAsync(new EventEntity
            {
                ExternalId = evt.ExternalId,
                Name = nameof(CreatedProductEvent),
                Payload = JsonSerializer.Serialize(evt),
                CreatedOn = evt.CreatedOn,
                CreatedBy = evt.CreatedBy,
            }, ct);
        }
    }
}
