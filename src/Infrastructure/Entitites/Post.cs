using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class Post : BaseAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public ICollection<Post_Tag> Tags { get; set; }
        public ICollection<FileAttachments> Files { get; set; }
        public ICollection<Post_Category> Categories { get; set; }
    }
}
