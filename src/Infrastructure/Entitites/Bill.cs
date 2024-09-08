using Core.Enums;

namespace Infrastructure.Entitites
{
    public class Bill : BaseAuditableEntity
    {
        public long Id { get; set; }
        /// <summary>
        /// Code generator //TODO
        /// </summary>
        public string Code { get; set; }
        public EBillType BillType { get; set; }
        public EBillStatusType BillStatusType { get; set; }
        public EBillAuthorType BillAuthorType { get; set; }
        public EPaymentMethodType PaymentMethodType { get; set; }

        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Note { get; set; }

        public decimal TaxRate { get; set; }


        public int? VoucherId { get; set; }
        public Voucher? Voucher { get; set; }


        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int? ShipId { get; set; }
        public float? ShipPrice { get; set; }
        public Ship? Ship { get; set; }

        public long? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }

    }
}
