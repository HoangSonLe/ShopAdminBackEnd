namespace Infrastructure.Entitites
{
    public class FileAttachments :BaseAuditableEntity
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public byte[] FileData { get; set; }

        public long ProductId { get; set; }
        public Product? Product { get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }
    }
}
