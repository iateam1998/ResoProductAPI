using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Voucher
    {
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public int? PromotionDetailId { get; set; }
        public int PromotionId { get; set; }
        public int Quantity { get; set; }
        public int UsedQuantity { get; set; }
        public bool Active { get; set; }
        public bool? IsGetted { get; set; }
        public bool? IsUsed { get; set; }
        public int? MembershipCardId { get; set; }

        public virtual Membership MembershipCard { get; set; }
        public virtual Promotion Promotion { get; set; }
        public virtual PromotionDetail PromotionDetail { get; set; }
    }
}
