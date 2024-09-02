using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class ShipEntityConfigurations : IEntityTypeConfiguration<Ship>
    {
        public void Configure(EntityTypeBuilder<Ship> builder)
        {
            // Primary key
            builder.HasKey(p => p.Id);

            // Relationships
            builder.HasMany(s => s.Bills)
                .WithOne(b => b.Ship)
                .HasForeignKey(b => b.ShipId)
                .OnDelete(DeleteBehavior.SetNull); // Set null on Bill's ShipId when Ship is deleted
            // Table
            builder.ToTable("Ships");
        }
    }
}
