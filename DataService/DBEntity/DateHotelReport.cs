using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class DateHotelReport
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string CreateBy { get; set; }
        public int Status { get; set; }
        public int StoreId { get; set; }
        public double TotalAmount { get; set; }
        public double Discount { get; set; }
        public double FinalAmount { get; set; }
        public double TotalOrderDetail { get; set; }
        public double TotalOrderFeeItem { get; set; }
    }
}
