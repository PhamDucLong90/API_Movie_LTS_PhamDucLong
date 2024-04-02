using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class ConfirmEmail
    {
        [Key]
        public int Id_ConfirmEmail { get; set; } // Primary key
        public int UserId { get; set; }
        public DateTime ExpiredTime { get; set; }
        public string ConfirmCode { get; set; }
        public bool IsConfirm { get; set; }
        public User User { get; set; }  
    }
}
