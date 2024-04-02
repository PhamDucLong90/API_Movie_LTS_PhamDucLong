using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class UserStatus
    {/*Id integer [primary key]
  Code varchar
  Name varchar*/
        [Key]
        public int Id_UserStatus { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> users { get; set; }
    }
}
