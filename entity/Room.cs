using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Room
    {
        /* Id integer [primary key]
  Capacity integer
  Type integer
  Description varchar
  CinemaId integer
  Code varchar
  Name varchar
  IsActive bit*/
        [Key]
        public int Id_Room { get; set; }
        public int Capacity { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string CinemaId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive {  get; set; }
        public Cinema Cinema { get; set; }
        public IEnumerable<Schedule> schedules { get; set; }
        public IEnumerable<Seat> seats { get; set; }
    }
}
