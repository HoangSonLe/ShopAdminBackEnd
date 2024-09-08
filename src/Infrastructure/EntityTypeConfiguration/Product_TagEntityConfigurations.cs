using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class Product_TagEntityConfigurations : IEntityTypeConfiguration<Product_Tag>
    {
        public void Configure(EntityTypeBuilder<Product_Tag> builder)
        {
            builder.HasKey(pt => new { pt.ProductId, pt.TagId });

            // Relationships
            builder.HasOne(pt => pt.Product)
                .WithMany(p => p.ProductTags)
                .HasForeignKey(pt => pt.ProductId);

            builder.HasOne(pt => pt.Tag)
                .WithMany(t => t.ProductTags)
                .HasForeignKey(pt => pt.TagId);
            // Table
            builder.ToTable("Product_Tag");
        }
    }
}
