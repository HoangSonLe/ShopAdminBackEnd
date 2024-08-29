using Core.Enums;
using Core.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entitites
{
    public class Unit : BaseAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public required string UnitName { get; set; }
        public required string UnitNameNonUnicode { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
