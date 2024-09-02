using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class User_RoleEntityConfigurations : IEntityTypeConfiguration<User_Role>
    {
        public void Configure(EntityTypeBuilder<User_Role> builder)
        {
            // Composite primary key
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            // Relationships
            builder.HasOne(ur => ur.User)
                .WithMany(u => u.Roles) // Navigation property in User entity
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when User is deleted

            builder.HasOne(ur => ur.Role)
                .WithMany(r => r.Users) // Navigation property in Role entity
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Role is deleted
            // Table
            builder.ToTable("User_Role");
        }
    }
}
