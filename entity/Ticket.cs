using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Ticket
    {
        [Key]
        public int Id_Ticket { get; set; } 
        public string Code { get; set; }
        public int ScheduleId { get; set; }
        public int SeatId { get; set; }
        public double PriceTicket { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BillTicket> billTickets { get; set; }
        public Schedule Schedule { get; set; }  
        public Seat Seat { get; set; }
    }
}
