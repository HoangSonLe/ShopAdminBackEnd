using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class Inventory : BaseAuditableEntity
    {
        [Key]
        public long Id { get; set; }
        public decimal Quantity { get; set; }


        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

    }
}
