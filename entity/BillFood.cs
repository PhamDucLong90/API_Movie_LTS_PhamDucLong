using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class BillFood
    {
        /*vId integer [primary key]
  Quantity integer
  BillId integer
  FoodId integer*/
        [Key]
        public int Id_BillFood {  get; set; }
        public int Quantity { get; set; }
        public int BillId { get; set; }
        public int FoodId { get; set; }
        public Bill Bill { get; set; }
        public Food Food { get; set; }
    }
}
