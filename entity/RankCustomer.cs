using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class RankCustomer
    {
        /*
         *  Id integer [primary key]
  Point integer
  Description varchar
  Name varchar
  IsActive bit
         */
        [Key]
        public int Id_RankCustomer { get; set; }
        public int Point {  get; set; }
        public string Description { get; set; }
        public bool IsActive {  get; set; }
        public IEnumerable<User> users { get; set; }    
        public IEnumerable<Promotion> promotions { get; set; }
        

    }
}
