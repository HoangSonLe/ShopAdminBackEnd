using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class ProductUnitEntityConfigurations : IEntityTypeConfiguration<ProductUnit>
    {
        public void Configure(EntityTypeBuilder<ProductUnit> builder)
        {
            builder.HasKey(pu => pu.Id);

            // Relationships
            builder.HasOne(pu => pu.Product)
                .WithMany(p => p.Units)
                .HasForeignKey(pu => pu.ProductId);

            builder.HasOne(pu => pu.Unit)
                .WithMany()
                .HasForeignKey(pu => pu.UnitId);

            builder.HasMany(pu => pu.RatioConversion)
                .WithOne()
                .HasForeignKey(e=> e.ProductUnitId); // Assuming ProductUnitId is in UnitConversion

            // Table
            builder.ToTable("ProductUnit");
        }
    }
}
