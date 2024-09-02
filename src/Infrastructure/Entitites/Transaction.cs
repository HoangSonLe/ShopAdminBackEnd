using Core.Enums;

namespace Infrastructure.Entitites
{
    public class Transaction
    {
        public long Id { get; set; }
        public decimal Quantity { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public long? BillId { get; set; }
        public BillDetail? BillDetail { get; set; }
        public long InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public ETransactionType TransactionType { get; set; }
    }
}
