using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class OrderFeeItem
    {
        public int OrderId { get; set; }
        public int RentId { get; set; }
        public double? TotalAmount { get; set; }
        public double? FinalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string DetailDescription { get; set; }
        public int? Status { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool IsAddition { get; set; }
        public int? ProductType { get; set; }
        public int? RoomId { get; set; }
        public string RoomName { get; set; }
        public int? RentMode { get; set; }
        public int? PriceGroupId { get; set; }

        public virtual PriceGroup PriceGroup { get; set; }
        public virtual Order Rent { get; set; }
    }
}
