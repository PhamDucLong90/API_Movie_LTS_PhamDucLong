using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Promotion
    {
        /* Id integer [primary key]
  Percent integer
  Quantity integer
  Type varchar
  StartTime datetime
  EndTime datetime
  Description varchar
  Name varchar
  IsActive bit
  RankCustomerId integer*/
        [Key]
        public int Id_Promotion { get; set; }
        public int Percent {  get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description {  get; set; }
        public bool IsActive {  get; set; }
        public int RankCustomerId {  get; set; }
        public RankCustomer RankCustomer { get; set; }
        public IEnumerable<Bill> bills { get; set; }
    }
}
