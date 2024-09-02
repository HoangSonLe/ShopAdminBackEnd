using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class UnitEntityConfigurations : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(pt => pt.Id);

            // Relationships
            builder.HasMany(u => u.ProductUnits)
                .WithOne(pu => pu.Unit) // Navigation property from ProductUnit
                .HasForeignKey(pu => pu.UnitId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Unit is deleted
            // Table
            builder.ToTable("Units");
        }
    }
}
