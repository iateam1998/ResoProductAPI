using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class AreaDelivery
    {
        public AreaDelivery()
        {
            District = new HashSet<District>();
            InverseArea = new HashSet<AreaDelivery>();
            Province = new HashSet<Province>();
        }

        public int Id { get; set; }
        public string AreaName { get; set; }
        public int? AreaType { get; set; }
        public decimal? PriceDelivery { get; set; }
        public int? AreaId { get; set; }
        public double? LimitAmount { get; set; }
        public bool? Active { get; set; }

        public virtual AreaDelivery Area { get; set; }
        public virtual ICollection<District> District { get; set; }
        public virtual ICollection<AreaDelivery> InverseArea { get; set; }
        public virtual ICollection<Province> Province { get; set; }
    }
}
