using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Coupon
    {
        public int Id { get; set; }
        public int? CampaginId { get; set; }
        public string SerialNumber { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; }
        public int? StoreId { get; set; }
        public DateTime? DateUse { get; set; }
        public string ImageUrl { get; set; }

        public virtual CouponCampaign Campagin { get; set; }
        public virtual Store Store { get; set; }
    }
}
