using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class BillTicket
    {
        [Key]

        public int Id_BillTicket { get; set; } // Primary key
        public int Quantity { get; set; }
        public int BillId { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public Bill Bill { get; set; }
    }
}
