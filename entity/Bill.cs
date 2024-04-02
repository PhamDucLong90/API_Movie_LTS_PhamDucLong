using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.entity
{
    public class Bill
    {
        /*
          Id integer [primary key]
  TotalMoney double
  TradingCode varchar
  CreateTime datetime
  CustomerId integer
  Name varchar 
  UpdateTime datetime
  PromotionId integer
  BillStatusId integer
  IsActive bit*/
        [Key]
        public int Id_Bill { get; set; }
        public double TotalMoney {  get; set; }
        public string TradingCode { get; set; }
        public int CustomerId {  get; set; }
        public string Name { get; set; }
        public DateTime UpdateTime {  get; set; }
        public int PromotionId {  get; set; }
        public int BillStatusId {  get; set; }
        public bool IsActive {  get; set; }
        public Promotion Promotion { get; set; }
        public BillStatus BillStatus {  get; set; }
        public User User { get; set; } 
        public IEnumerable<BillFood> billFoods {  get; set; }
        public IEnumerable<BillTicket> billTickets { get; set; }

    }
}
