namespace Infrastructure.Entitites
{
    public class Product_Tag
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
