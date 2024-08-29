using Core.Enums;
using Core.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public ICollection<Post_Tag> PostTags { get; set; }
    }
}
