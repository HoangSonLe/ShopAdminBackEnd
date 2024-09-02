using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class Post_CategoryEntityConfigurations : IEntityTypeConfiguration<Post_Category>
    {
        public void Configure(EntityTypeBuilder<Post_Category> builder)
        {
            builder.HasKey(pc => new { pc.PostId, pc.CategoryId }); // Composite primary key

            // Relationships
            builder.HasOne(pc => pc.Post)
                .WithMany(p => p.Categories)
                .HasForeignKey(pc => pc.PostId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Post is deleted

            builder.HasOne(pc => pc.Category)
                .WithMany(c => c.Posts)
                .HasForeignKey(pc => pc.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Table
            builder.ToTable("Post_Category");
        }
    }
}
