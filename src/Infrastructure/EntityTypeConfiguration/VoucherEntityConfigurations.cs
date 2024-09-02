using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class VoucherEntityConfigurations : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(pu => pu.Id);

            builder.HasMany(v => v.Bills)
                .WithOne(b => b.Voucher)
                .HasForeignKey(b => b.VoucherId)
                .OnDelete(DeleteBehavior.SetNull); // If a voucher is deleted, set the VoucherId in Bill to null
            // Table
            builder.ToTable("Vouchers");
        }
    }
}
