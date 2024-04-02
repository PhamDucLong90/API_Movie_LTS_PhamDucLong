using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Project_XemPhim.entity
{
    public class Role
    {
        /*
         Id integer [primary key]
  Code varchar
  RoleName varcharv*/
        [Key]
        public int Id_Role { get; set; }
        public string Code {  get; set; }
        public string RoleName {  get; set; }
        public IEnumerable<User> users { get; set; }

    }
}
