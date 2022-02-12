using IM.Domain;
using IM.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace IM.Infrastructure
{
    public class InventoryContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }
        public InventoryContext(DbContextOptions<InventoryContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InventoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}