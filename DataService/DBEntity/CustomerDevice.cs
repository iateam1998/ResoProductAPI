using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CustomerDevice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Fcmtoken { get; set; }
        public int? DeviceType { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
