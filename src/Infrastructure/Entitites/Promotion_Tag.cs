namespace Infrastructure.Entitites
{
    public class Promotion_Tag
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}
