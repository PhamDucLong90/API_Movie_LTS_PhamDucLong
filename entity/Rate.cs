using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Rate
    {
        /* Id integer [primary key]
  Description varchar
  Code varchar*/
        [Key]
        public int Id_Rate { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public IEnumerable<Movie> movies { get; set; }
        
    }
}
