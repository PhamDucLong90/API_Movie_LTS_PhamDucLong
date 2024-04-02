using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class RefreshToken
    {
        /* Id integer [primary key]
  Token varchar
  ExpiredTime datetime
  UserId integer*/
        [Key]
        public int Id_RefreshToken { get; set; }
        public string Token { get; set; }
        public DateTime ExpiredTime { get; set; }
        public int UserId { get; set; }

        public User user { get; set; }

    }
}
