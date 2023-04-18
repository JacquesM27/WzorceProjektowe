using Mediator2.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mediator2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductEntity>(config =>
            {
                config.HasKey(e => e.Id);
                config.HasAlternateKey(e => e.ExternalId);
                config.Property(e => e.ExternalId).IsRequired();
                config.HasIndex(e => e.Code).IsUnique();
                config.Property(e => e.Code).IsRequired().HasMaxLength(8);
                config.Property(e => e.Name).IsRequired().HasMaxLength(128);
                config.Property(e => e.Price).IsRequired();
            });

            modelBuilder.Entity<EventEntity>(config =>
            {
                config.HasKey(e => e.Id);
                config.HasAlternateKey(e => e.ExternalId);
                config.HasIndex(e => e.CreatedOn);
                config.Property(e => e.Name).IsRequired().HasMaxLength(128);
                config.Property(e => e.Payload).IsRequired();
                config.Property(e => e.CreatedOn).IsRequired();
                config.Property(e => e.CreatedBy).IsRequired().HasMaxLength(128);
            });
        }
    }
}
