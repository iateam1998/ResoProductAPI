using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            InverseParent = new HashSet<OrderDetail>();
            OrderDetailPromotionMappingNavigation = new HashSet<OrderDetailPromotionMapping>();
        }

        public int OrderDetailId { get; set; }
        public int RentId { get; set; }
        public int ProductId { get; set; }
        public double TotalAmount { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public double FinalAmount { get; set; }
        public bool? IsAddition { get; set; }
        public string DetailDescription { get; set; }
        public double Discount { get; set; }
        public double? TaxPercent { get; set; }
        public double? TaxValue { get; set; }
        public double UnitPrice { get; set; }
        public int? ProductType { get; set; }
        public int? ParentId { get; set; }
        public int? StoreId { get; set; }
        public int? ProductOrderType { get; set; }
        public int ItemQuantity { get; set; }
        public int? TmpDetailId { get; set; }
        public int? OrderDetailPromotionMappingId { get; set; }
        public int? OrderPromotionMappingId { get; set; }
        public string OrderDetailAtt1 { get; set; }
        public string OrderDetailAtt2 { get; set; }
        public bool? Active { get; set; }

        public virtual OrderDetailPromotionMapping OrderDetailPromotionMapping { get; set; }
        public virtual OrderPromotionMapping OrderPromotionMapping { get; set; }
        public virtual OrderDetail Parent { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Rent { get; set; }
        public virtual ICollection<OrderDetail> InverseParent { get; set; }
        public virtual ICollection<OrderDetailPromotionMapping> OrderDetailPromotionMappingNavigation { get; set; }
    }
}
