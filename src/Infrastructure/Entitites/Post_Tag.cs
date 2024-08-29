namespace Infrastructure.Entitites
{
    public class Post_Tag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
