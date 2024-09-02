using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class EmployeeEntityConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Primary key
            builder.HasKey(p => p.EmployeeId);
            // Relationships
            builder.HasOne(e => e.User)
                .WithOne(u => u.Employee)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of User if associated with Employee

            builder.HasMany(e => e.Bills)
                .WithOne(b => b.Employee)
                .HasForeignKey(b => b.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Employee is deleted

            // Table
            builder.ToTable("Employees");
        }
    }
}
