namespace Infrastructure.Entitites
{
    public class ProductUnit
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public List<UnitConversion> RatioConversion { get; set; }
    }

}
