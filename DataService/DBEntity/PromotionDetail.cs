using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PromotionDetail
    {
        public PromotionDetail()
        {
            Voucher = new HashSet<Voucher>();
        }

        public int PromotionDetailId { get; set; }
        public string PromotionCode { get; set; }
        public string PromotionDetailCode { get; set; }
        public string RegExCode { get; set; }
        public double? MinOrderAmount { get; set; }
        public double? MaxOrderAmount { get; set; }
        public string BuyProductCode { get; set; }
        public int? MinBuyQuantity { get; set; }
        public int? MaxBuyQuantity { get; set; }
        public string GiftProductCode { get; set; }
        public int? GiftQuantity { get; set; }
        public double? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? PointTrade { get; set; }
        public int? MinPoint { get; set; }
        public int? MaxPoint { get; set; }
        public int? CustomerCashbackMode { get; set; }
        public int? CustomerCashbackAccountType { get; set; }
        public double? CustomerCashbackAmount { get; set; }
        public double? MaxCustomerCashbackAmount { get; set; }
        public int? AffliatorCashbackMode { get; set; }
        public int? AffliatorCashbackAccountType { get; set; }
        public double? AffliatorCashbackAmount { get; set; }
        public double? MaxAffliatorCashbackAmount { get; set; }

        public virtual Promotion PromotionCodeNavigation { get; set; }
        public virtual ICollection<Voucher> Voucher { get; set; }
    }
}
