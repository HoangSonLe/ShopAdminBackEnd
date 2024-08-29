using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class Category : BaseAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public required string CategoryName { get; set; }
        public required string CategoryNameNonUnicode { get; set; }
        public ECategoryType CategoryType { get; set; }
        public string Description { get; set; }

        public ICollection<Post_Category> Posts { get; set; }
    }
}
