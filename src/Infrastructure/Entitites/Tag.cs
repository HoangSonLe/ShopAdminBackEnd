using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class Tag : BaseAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public required string TagName { get; set; }
        public required string TagNameNonUnicode { get; set; }
        public ETagType TagType { get; set; }
        public string Description { get; set; }

        public ICollection<Product_Tag> ProductTags { get; set; }
        public ICollection<Product> Products => ProductTags?.Select(pt => pt.Product).ToList();

        public ICollection<Post_Tag> Posts { get; set; }
        public ICollection<Promotion_Tag> Promotions { get; set; }
    }
}
