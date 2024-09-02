using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class CustomerEntityConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId); // Primary key

            // Relationships
            builder.HasOne(c => c.User)
                .WithOne(u => u.Customer)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of User if associated with Customer

            builder.HasMany(c => c.Bills)
                .WithOne(b => b.Customer)
                .HasForeignKey(b => b.CustomerId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Customer is deleted
            // Table
            builder.ToTable("Customers");
        }
    }
}
