using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class InventoryTransactionEntityConfigurations : IEntityTypeConfiguration<InventoryTransaction>
    {
        public void Configure(EntityTypeBuilder<InventoryTransaction> builder)
        {
            // Primary key
            builder.HasKey(p => p.Id);
            // Relationships
            builder.HasOne(it => it.BillDetail)
                .WithOne(b => b.InventoryTransaction)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Bill if associated with InventoryTransaction

            builder.HasOne(it => it.Unit)
                .WithMany()
                .HasForeignKey(it => it.UnitId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Unit if associated with InventoryTransaction

            builder.HasOne(it => it.Product)
                .WithMany(p => p.InventoryTransactions)
                .HasForeignKey(it => it.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Product if associated with InventoryTransaction

            builder.HasOne(it => it.Warehouse)
                .WithMany(w => w.InventoryTransactions)
                .HasForeignKey(it => it.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Warehouse if associated with InventoryTransaction

            // Table
            builder.ToTable("InventoryTransactions");
        }
    }
}
