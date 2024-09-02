using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class FileAttachmentsEntityConfigurations : IEntityTypeConfiguration<FileAttachments>
    {
        public void Configure(EntityTypeBuilder<FileAttachments> builder)
        {
            // Primary key
            builder.HasKey(p => p.Id);
            // Relationships
            builder.HasOne(f => f.Product)
                .WithMany(p => p.Images)
                .HasForeignKey(f => f.ProductId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Product is deleted

            builder.HasOne(f => f.Post)
                .WithMany(p => p.Files)
                .HasForeignKey(f => f.PostId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Post is deleted
            // Table
            builder.ToTable("FileAttachments");
        }
    }
}
