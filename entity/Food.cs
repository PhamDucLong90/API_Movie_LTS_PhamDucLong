using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Food
    {
        /* Id integer [primary key]
  Price double
  Description varchar
  Image varchar
  NameOfFood varchar
  IsActive bit*/
        [Key]
        public int Id_Food {  get; set; }
        public double Price {  get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public string NameOfFood { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BillFood> billFoods { get; set; }
    }
}
