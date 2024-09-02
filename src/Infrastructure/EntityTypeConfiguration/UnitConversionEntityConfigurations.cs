using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class UnitConversionEntityConfigurations : IEntityTypeConfiguration<UnitConversion>
    {
        public void Configure(EntityTypeBuilder<UnitConversion> builder)
        {
            // Composite primary key
            builder.HasKey(uc => new { uc.ProductUnitId, uc.FromUnitId, uc.ToUnitId });

            // Relationships
            builder.HasOne(uc => uc.ProductUnit)
                .WithMany(pu => pu.RatioConversion) // Navigation property from ProductUnit
                .HasForeignKey(uc => uc.ProductUnitId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when ProductUnit is deleted

            builder.HasOne(uc => uc.FromUnit)
                .WithMany()
                .HasForeignKey(uc => uc.FromUnitId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            builder.HasOne(uc => uc.ToUnit)
                .WithMany()
                .HasForeignKey(uc => uc.ToUnitId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            // Table
            builder.ToTable("UnitConversions");
        }
    }
}
