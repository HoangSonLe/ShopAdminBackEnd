using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class Promotion_TagEntityConfigurations : IEntityTypeConfiguration<Promotion_Tag>
    {
        public void Configure(EntityTypeBuilder<Promotion_Tag> builder)
        {
            builder.HasKey(pt => new { pt.PromotionId, pt.TagId });

            // Relationships
            builder.HasOne(pt => pt.Promotion)
                .WithMany(p => p.Tags)
                .HasForeignKey(pt => pt.PromotionId);

            builder.HasOne(pt => pt.Tag)
                .WithMany(t => t.Promotions)
                .HasForeignKey(pt => pt.TagId);
            // Table
            builder.ToTable("Promotion_Tag");
        }
    }
}
