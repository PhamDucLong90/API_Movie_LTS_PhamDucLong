using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Cinema
    {
        /* Id integer [primary key]
  Address varchar 
  Description varchar
  Code varchar
  NameOfCinema varchar
  IsActive bit*/
        [Key]
        public int Id_Cinema { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string NameOfCinema { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Room> rooms { get; set; }
    }
}
