using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class DeliveryInfo
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }
        public int? Type { get; set; }
        public bool? IsDefaultDeliveryInfo { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
