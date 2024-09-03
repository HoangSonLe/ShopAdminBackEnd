using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class BillDetailEntityConfigurations : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            // Primary key
            builder.HasKey(p => p.Id);

            // Relationships
            builder.HasOne(bd => bd.Bill)
                .WithMany(b => b.BillDetails)
                .HasForeignKey(bd => bd.BillId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Bill is deleted

            builder.HasOne(bd => bd.Product)
                .WithMany()
                .HasForeignKey(bd => bd.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Product if used in BillDetail

            builder.HasOne(bd => bd.UnitPrice)
                .WithMany()
                .HasForeignKey(bd => bd.UnitPriceId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of UnitPrice if used in BillDetail

            builder.HasOne(bd => bd.Unit)
                .WithMany()
                .HasForeignKey(bd => bd.UnitId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of Unit if used in BillDetail

            builder.HasOne(bd => bd.InventoryTransaction)
                    .WithMany() // Assuming no collection in InventoryTransaction entity
                    .HasForeignKey(bd => bd.InventoryTransactionId)
                    .OnDelete(DeleteBehavior.Restrict);
            // Table
            builder.ToTable("BillDetails");
        }
    }
}
