using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class WarehouseEntityConfigurations : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.HasKey(pt => pt.Id);

            // Relationships
            builder.HasMany(w => w.Inventories)
                .WithOne(i => i.Warehouse) // Navigation property in Inventory
                .HasForeignKey(i => i.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Warehouse is deleted

            builder.HasMany(w => w.InventoryTransactions)
                .WithOne(it => it.Warehouse) // Navigation property in InventoryTransaction
                .HasForeignKey(it => it.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Warehouse is deleted

            // Table
            builder.ToTable("Warehouses");
        }
    }
}
