using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class InventoryEntityConfigurations : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(i => i.Id); // Primary key

            // Relationships
            builder.HasOne(i => i.Unit)
                .WithMany()
                .HasForeignKey(i => i.UnitId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Unit if associated with Inventory

            builder.HasOne(i => i.Product)
                .WithMany(p => p.Inventories)
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Product is deleted

            builder.HasOne(i => i.Warehouse)
                .WithMany(w => w.Inventories)
                .HasForeignKey(i => i.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Warehouse if associated with Inventory

            builder.HasMany(i => i.Transactions)
                .WithOne(t => t.Inventory)
                .HasForeignKey(t => t.InventoryId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Inventory is deleted
            // Table
            builder.ToTable("Inventories");
        }
    }
}
