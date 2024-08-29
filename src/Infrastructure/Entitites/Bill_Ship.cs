namespace Infrastructure.Entitites
{
    public class Bill_Ship : BaseAuditableEntity
    {
        public long BillId { get; set; }
        public Bill Bill { get; set; }
        public int ShipId { get; set; }
        public Ship Ship { get; set; }
    }
}
