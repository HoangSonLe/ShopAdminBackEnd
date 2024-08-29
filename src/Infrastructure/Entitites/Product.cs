using Core.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entitites
{
    public class Product : BaseAuditableEntity
    {
        [Key]
        public long Id { get; set; }
        public required string ProductName { get; set; }
        public required string ProductNameUnicode { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }


        public int UnitPriceId { get; set; }
        public Unit UnitPrice { get; set; }

        public ICollection<Product_Image> Images { get; set; }
        public ICollection<Product_Tag> Tags { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
