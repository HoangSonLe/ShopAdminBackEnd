using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class User : BaseAuditableEntity
    {
        [Key]
        public long Id { get; set; }
        public required string UserName { get; set; }
        public required string PasswordHash { get; set; }
        public string? Email { get; set; }

        public required string PhoneNumber { get; set; } = "";
        public List<User_Role> Roles { get; set; }
        public EAccountType AccountType { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public Customer? Customer { get; set; }
        public Employee? Employee { get; set; }
    }
}
