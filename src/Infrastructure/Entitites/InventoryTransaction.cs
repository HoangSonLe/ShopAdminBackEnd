using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class InventoryTransaction :BaseAuditableEntity
    {
        [Key]
        public long Id { get; set; }
        public decimal Quantity { get; set; }

        public ETransactionType TransactionType { get; set; }

        public long BillDetailId { get; set; }
        public BillDetail BillDetail { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
