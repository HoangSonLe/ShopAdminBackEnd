namespace Infrastructure.Entitites
{
    public class Product_Image
    {
        public long FileId { get; set; }
        public FileAttachments ImageUrl { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
