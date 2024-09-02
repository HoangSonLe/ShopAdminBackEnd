using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class BillEntityConfigurations : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            // Primary key
            builder.HasKey(p => p.Id);
            // Configure the relationships
            builder.HasOne(e => e.Voucher)
                .WithMany() // Assuming no navigation property on Voucher for Bill
                .HasForeignKey(e => e.VoucherId)
                .OnDelete(DeleteBehavior.SetNull); // Adjust DeleteBehavior as needed

            builder.HasOne(b => b.Customer)
                    .WithMany(c => c.Bills)
                    .HasForeignKey(b => b.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Ship)
                .WithMany() // Assuming no navigation property on Ship for Bill
                .HasForeignKey(e => e.ShipId)
                .OnDelete(DeleteBehavior.SetNull); // Adjust DeleteBehavior as needed

            builder.HasOne(b => b.Employee)
               .WithMany(e => e.Bills)
               .HasForeignKey(b => b.EmployeeId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(b => b.BillDetails)
                            .WithOne(bd => bd.Bill)
                            .HasForeignKey(bd => bd.BillId);
            
            // Table
            builder.ToTable("Bills");
        }
    }
}
