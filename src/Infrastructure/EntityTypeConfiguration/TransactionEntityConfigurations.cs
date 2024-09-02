using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class TransactionEntityConfigurations : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(pu => pu.Id);

            // Relationships
            builder.HasOne(t => t.Unit)
                .WithMany()
                .HasForeignKey(t => t.UnitId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict delete to avoid cascade issues

            builder.HasOne(t => t.Warehouse)
                .WithMany()
                .HasForeignKey(t => t.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict delete to avoid cascade issues

            builder.HasOne(t => t.BillDetail)
                .WithMany()
                .HasForeignKey(t => t.BillId)
                .OnDelete(DeleteBehavior.SetNull); // Set null on BillDetail reference when Bill is deleted

            builder.HasOne(t => t.Inventory)
                .WithMany(i => i.Transactions)
                .HasForeignKey(t => t.InventoryId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Inventory is deleted

            // Table
            builder.ToTable("Transactions");
        }
    }
}
