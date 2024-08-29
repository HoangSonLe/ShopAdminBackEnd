using Infrastructure.Entitites;

namespace Infrastructure.DBContexts
{
    public class Promotion_Product
    {
        public long ProductId {  get; set; }
        public Product Product { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}
