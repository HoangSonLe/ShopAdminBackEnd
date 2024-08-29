using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitites
{
    public class EmployeeInfor
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string FirstNameNonUnicode { get; set; }
        public string LastName { get; set; }
        public string LastNameNonUnicode { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public ERoleType RoleType { get; set; }
        public string Department { get; set; }

        // Foreign Key and Navigation property
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
