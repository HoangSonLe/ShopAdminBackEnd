using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class UserEntityConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Primary key
            builder.HasKey(p => p.Id);

            // Relationships
            builder.HasMany(u => u.Roles)
                   .WithOne(i=> i.User)
                   .HasForeignKey(ur => ur.UserId) // Giả sử User_Role có UserId là khóa ngoại
                   .OnDelete(DeleteBehavior.Cascade); // Xóa User sẽ xóa các vai trò liên quan

            builder.HasOne(u => u.Customer)
                   .WithOne(c => c.User)
                   .HasForeignKey<Customer>(c => c.UserId)
                   .OnDelete(DeleteBehavior.Restrict); // Thiết lập quan hệ 1-1

            builder.HasOne(u => u.Employee)
                   .WithOne(e => e.User)
                   .HasForeignKey<Employee>(e => e.UserId)
                   .OnDelete(DeleteBehavior.Restrict); // Thiết lập quan hệ 1-1

            // Table Mapping (Nếu cần, định nghĩa tên bảng khác)
            builder.ToTable("Users");
        }
    }
}
