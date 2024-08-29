namespace Infrastructure.Entitites
{
    public class CustomerInfor
    {
        public long CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public string FirstName { get; set; }
        public string FirstNameNonUnicode { get; set; }
        public string LastName { get; set; }
        public string LastNameNonUnicode { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingAddressNonUnicode { get; set; }
        public string BillingAddress { get; set; }
        public string BillingAddressNonUnicode { get; set; }

        // Foreign Key and Navigation property
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
