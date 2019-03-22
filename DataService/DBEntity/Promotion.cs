using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Promotion
    {
        public Promotion()
        {
            OrderDetailPromotionMapping = new HashSet<OrderDetailPromotionMapping>();
            OrderPromotionMapping = new HashSet<OrderPromotionMapping>();
            PromotionDetail = new HashSet<PromotionDetail>();
            PromotionStoreMapping = new HashSet<PromotionStoreMapping>();
            Voucher = new HashSet<Voucher>();
        }

        public int PromotionId { get; set; }
        public string PromotionCode { get; set; }
        public string PromotionName { get; set; }
        public string PromotionClassName { get; set; }
        public string Description { get; set; }
        public string ImageCss { get; set; }
        public int ApplyLevel { get; set; }
        public int GiftType { get; set; }
        public bool IsForMember { get; set; }
        public bool Active { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? ApplyFromTime { get; set; }
        public int? ApplyToTime { get; set; }
        public int? BrandId { get; set; }
        public string ImageUrl { get; set; }
        public bool? IsVoucher { get; set; }
        public bool? IsApplyOnce { get; set; }
        public int? VoucherQuantity { get; set; }
        public int? VoucherUsedQuantity { get; set; }
        public int PromotionType { get; set; }
        public int? FromHappyDay { get; set; }
        public int? ToHappyDay { get; set; }
        public int? FromHoursHappy { get; set; }
        public int? ToHoursHappy { get; set; }
        public bool? UsingPoint { get; set; }
        public int? ApplyToPartner { get; set; }

        public virtual ICollection<OrderDetailPromotionMapping> OrderDetailPromotionMapping { get; set; }
        public virtual ICollection<OrderPromotionMapping> OrderPromotionMapping { get; set; }
        public virtual ICollection<PromotionDetail> PromotionDetail { get; set; }
        public virtual ICollection<PromotionStoreMapping> PromotionStoreMapping { get; set; }
        public virtual ICollection<Voucher> Voucher { get; set; }
    }
}
