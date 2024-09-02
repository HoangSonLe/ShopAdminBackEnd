using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class Unit : BaseAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public required string UnitName { get; set; }
        public required string UnitNameNonUnicode { get; set; }
        public string Description { get; set; }
        public ICollection<ProductUnit> ProductUnits { get; set; }
    }
}
