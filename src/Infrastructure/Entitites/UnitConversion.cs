namespace Infrastructure.Entitites
{
    public class UnitConversion
    {
        public int ProductUnitId { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public int FromUnitId { get; set; }
        public Unit FromUnit { get; set; }
        public int ToUnitId { get; set; }
        public Unit ToUnit { get; set; }
        public decimal Ratio { get; set; }
    }
}
