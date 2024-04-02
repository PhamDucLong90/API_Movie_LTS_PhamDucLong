using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Schedule
    {
        /* Id integer [primary key]
  Price double
  StartAt datetime
  EndAt datetime
  Code varchar
  MovieId integer
  Name varchar
  RoomId integer
  IsActive bit*/
        [Key]
        public int Id_Shedule { get; set; }
        public double Price { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string Code {  get; set; }
        public int MovieId {  get; set; }
        public string Name {  get; set; }
        public int RoomId { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Ticket> tickets { get; set;}
        public Room Room { get; set; }  
        public Movie Movie { get; set; }
    }
}
