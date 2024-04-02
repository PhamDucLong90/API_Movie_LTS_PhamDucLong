using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class GeneralSetting
    {
        [Key]
        public int Id_GeneralSetting { get; set; } // Primary key
        public DateTime BreakTime { get; set; }
        public int BusinessHours { get; set; }
        public DateTime CloseTime { get; set; }
        public double FixedTicketPrice { get; set; }
        public int PercentDay { get; set; }
        public int PercentWeekend { get; set; }
        public DateTime TimeBeginToChange { get; set; }


    }
}
