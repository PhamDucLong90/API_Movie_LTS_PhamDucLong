using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class SeatType
    {
        [Key]
        public int Id_SeatType { get; set; } // Primary key
        public string Code { get; set; }
        public string NameStatus { get; set; }
        public IEnumerable<Seat> seats { get; set; }
    }
}
