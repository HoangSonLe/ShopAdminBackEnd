namespace Infrastructure.Entitites
{
    public class User_Role
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
