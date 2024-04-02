using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class User
    {
        /*Id integer [primary key]
  Point integer
  Username varchar
  Email varchar
  Name varchar
  PhoneNumber varchar
  Password varchar
  RankCustomerId integer
  UserStatusId integer
  IsActive bit
  RoleId integer*/
        [Key]
        public int Id_User { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int RankCustomerId { get; set; }
        public int UserStatusId { get; set; }
        public bool IsAdmin { get; set; }
        public int RoleId { get; set; }
        public IEnumerable<RefreshToken> refreshTokens { get; set; }
        public IEnumerable<ConfirmEmail> confirmEmails { get; set; }
        public IEnumerable<Bill> bills { get; set; }
        public UserStatus UserStatus {  get; set; }
        public Role Role { get; set; }
        public RankCustomer RankCustomer { get; set; }
    }
}
