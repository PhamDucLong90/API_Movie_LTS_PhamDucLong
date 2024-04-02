using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Banner
    {
        [Key]
        public int Id_Banner { get; set; } // Primary key
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
