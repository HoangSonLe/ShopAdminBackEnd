namespace Infrastructure.Entitites
{
    public class Bill_Voucher
    {
        public long? BillId { get; set; }
        public long VoucherId { get; set; }
        public long? ProductId { get; set; }

        public Bill? Bill { get; set; }
        public Product? Product { get; set; }
        public Voucher Voucher { get; set; }
    }
}
