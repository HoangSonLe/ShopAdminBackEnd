using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class BillDetail
    {
        [Key] 
        public long Id { get; set; }
        public long BillId { get; set; }
        public Bill Bill { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public int UnitPriceId { get; set; }
        public Unit UnitPrice { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }

        public long InventoryTransactionId { get; set; }
        public InventoryTransaction InventoryTransaction { get; set; }
    }
}
