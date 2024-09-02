using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class Post_TagEntityConfigurations : IEntityTypeConfiguration<Post_Tag>
    {
        public void Configure(EntityTypeBuilder<Post_Tag> builder)
        {
            // Composite primary key
            builder.HasKey(pt => new { pt.PostId, pt.TagId });

            // Relationships
            builder.HasOne(pt => pt.Post)
                .WithMany(p => p.Tags)
                .HasForeignKey(pt => pt.PostId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Product is deleted

            builder.HasOne(pt => pt.Tag)
                .WithMany(t => t.Posts)
                .HasForeignKey(pt => pt.TagId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Tag is deleted
            // Table
            builder.ToTable("Post_Tag");
        }
    }
}
