namespace Infrastructure.Entitites
{
    public class Product_Image
    {
        public int ProductImageId { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
