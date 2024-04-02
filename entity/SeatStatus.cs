using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class SeatStatus
    {
        [Key]
        public int Id_SeatStatus { get; set; } // Primary key
        public string Code { get; set; }
        public string NameStatus { get; set; }
        public IEnumerable<Seat> seats { get; set; }
    }
}
