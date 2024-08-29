namespace Infrastructure.Entitites
{
    public class FileAttachments :BaseAuditableEntity
    {
        public long FileId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public byte[] FileData { get; set; }
    }
}
