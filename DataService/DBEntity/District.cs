using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class District
    {
        public District()
        {
            DeliveryInformation = new HashSet<DeliveryInformation>();
            Order = new HashSet<Order>();
            Ward = new HashSet<Ward>();
        }

        public int DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public string DistrictType { get; set; }
        public int ProvinceCode { get; set; }
        public decimal? PriceDelivery { get; set; }
        public int? AreaDistrictId { get; set; }

        public virtual AreaDelivery AreaDistrict { get; set; }
        public virtual Province ProvinceCodeNavigation { get; set; }
        public virtual ICollection<DeliveryInformation> DeliveryInformation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Ward> Ward { get; set; }
    }
}
