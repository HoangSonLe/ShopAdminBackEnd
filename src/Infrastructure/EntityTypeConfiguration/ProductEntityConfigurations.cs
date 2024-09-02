using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class ProductEntityConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Primary key
            builder.HasKey(p => p.Id);

            // Configure the relationships
            builder.HasOne(e => e.UnitPrice)
                .WithMany() // Assuming no navigation property on Unit for Product
                .HasForeignKey(e => e.UnitPriceId)
                .OnDelete(DeleteBehavior.Restrict); // Adjust DeleteBehavior as needed

            builder.HasMany(e => e.Units)
                .WithOne(e => e.Product) // Assuming no navigation property on ProductUnit for Product
                .HasForeignKey(e => e.ProductId); // Replace with actual foreign key if needed

            builder.HasMany(e => e.Images)
               .WithOne(i => i.Product)
               .HasForeignKey(i => i.ProductId)
               .OnDelete(DeleteBehavior.Cascade); // Adjust DeleteBehavior as needed

            builder.HasMany(e => e.BillDetails)
                .WithOne(bd => bd.Product) // Assuming no navigation property on BillDetail for Product
                .HasForeignKey(e => e.ProductId); // Replace with actual foreign key if needed

            builder.HasMany(e => e.ProductTags)
                .WithOne() // Assuming no navigation property on Product_Tag for Product
                .HasForeignKey(e => e.ProductId); // Replace with actual foreign key if needed

            builder.HasMany(e => e.Inventories)
                .WithOne() // Assuming no navigation property on Inventory for Product
                .HasForeignKey(e => e.ProductId); // Replace with actual foreign key if needed

            // Table
            builder.ToTable("Products");
        }
    }
}
