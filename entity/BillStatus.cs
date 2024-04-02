using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class BillStatus
    {/* Id integer [primary key]
  Name varchar*/
        [Key]
        public int Id_BillStatus { get; set; }
        public string Name { get; set; }
        public IEnumerable<Bill> bills { get; set; }
    }
}
