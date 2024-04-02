using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Seat
    {
        [Key]
        public int Id_Seat { get; set; } // Primary key
        public int Number { get; set; }
        public int SeatStatusId { get; set; }
        public string Line { get; set; }
        public int RoomId { get; set; }
        public bool IsActive { get; set; }
        public int SeatTypeId { get; set; }
        public SeatType SeatType { get; set; }
        public SeatStatus SeatStatus { get; set; }  
        public Room Room { get; set; }
        public IEnumerable<Ticket> tickets { get; set; }
    }
}
