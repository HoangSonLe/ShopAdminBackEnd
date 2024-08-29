using Core.Enums;
using Core.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entitites
{
    public class User : BaseAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string PasswordHash { get; set; }
        public string? Email { get; set; }

        public required string PhoneNumber { get; set; } = "";
        public List<int> RoleIdList { get; set; }
        [NotMapped]
        public List<RoleViewModel> RoleList { get; set; } = new List<RoleViewModel>();
        public EAccountType AccountType { get; set; } // loại tk : admin - người dùng
        public string RefreshToken { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public CustomerInfor Customer { get; set; }
        public EmployeeInfor Employee { get; set; }
    }
}
