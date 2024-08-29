namespace Infrastructure.Entitites
{
    public class Warehouse :BaseAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameNonUnicode { get; set; }

        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<InventoryTransaction> Transactions { get; set; }
    }
}
