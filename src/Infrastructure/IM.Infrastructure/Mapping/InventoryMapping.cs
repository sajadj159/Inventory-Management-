using IM.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IM.Infrastructure.Mapping
{
    public class InventoryMapping : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventories");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Product);
            builder.Property(p => p.UnitPrice);
            builder.Property(p => p.InStock);
        }
    }
}