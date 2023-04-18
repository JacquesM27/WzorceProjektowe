namespace Mediator2.Data.Entities
{
    public class ProductEntity
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
