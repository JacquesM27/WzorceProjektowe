namespace Mediator2.Data.Entities
{
    public class EventEntity
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Payload { get; set; } = string.Empty;
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
    }
}
