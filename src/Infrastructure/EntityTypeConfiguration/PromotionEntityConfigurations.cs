using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class PromotionEntityConfigurations : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.HasKey(pu => pu.Id);

            // Relationships
            builder.HasMany(p => p.Tags)
                .WithOne(pt => pt.Promotion)
                .HasForeignKey(pt => pt.PromotionId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Promotion is deleted
            // Table
            builder.ToTable("Promotions");
        }
    }
}
