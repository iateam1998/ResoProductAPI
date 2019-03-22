using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Ward
    {
        public Ward()
        {
            Order = new HashSet<Order>();
        }

        public int WardCode { get; set; }
        public string WardName { get; set; }
        public string WardType { get; set; }
        public int DistrictCode { get; set; }

        public virtual District DistrictCodeNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
