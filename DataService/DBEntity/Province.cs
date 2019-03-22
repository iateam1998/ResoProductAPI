using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Province
    {
        public Province()
        {
            DeliveryInformation = new HashSet<DeliveryInformation>();
            District = new HashSet<District>();
            Order = new HashSet<Order>();
        }

        public int ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceType { get; set; }
        public decimal? BasePriceDelivery { get; set; }
        public int? AreaProvinceId { get; set; }

        public virtual AreaDelivery AreaProvince { get; set; }
        public virtual ICollection<DeliveryInformation> DeliveryInformation { get; set; }
        public virtual ICollection<District> District { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
