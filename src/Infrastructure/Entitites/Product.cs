using System.ComponentModel.DataAnnotations;

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
        public ICollection<ProductUnit> Units { get; set; }


        public ICollection<FileAttachments> Images { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }

        public ICollection<Product_Tag> ProductTags { get; set; }
        //public ICollection<Tag> Tags => ProductTags?.Select(pt => pt.Tag).ToList();

        public ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
