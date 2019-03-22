using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CouponCampaign
    {
        public CouponCampaign()
        {
            Coupon = new HashSet<Coupon>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Status { get; set; }
        public decimal Price { get; set; }
        public decimal Value { get; set; }
        public int? ProviderId { get; set; }
        public bool IsActive { get; set; }
        public int? BrandId { get; set; }

        public virtual CouponProvider Provider { get; set; }
        public virtual ICollection<Coupon> Coupon { get; set; }
    }
}
