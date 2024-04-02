using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Project_XemPhim.entity
{
    public class MovieType
    {
        /* Id integer [primary key]
  MovieTypeName varchar
  IsActive bit*/
        [Key]
        public int Id_MovieType {  get; set; }
        public string MoiveTypeName {  get; set; }
        public bool IsActive {  get; set; }
        public IEnumerable<Movie> movies { get; set; }
    }
}
