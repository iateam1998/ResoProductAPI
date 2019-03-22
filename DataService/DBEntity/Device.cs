using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Device
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string DeviceCode { get; set; }
        public string Config { get; set; }
        public bool? Status { get; set; }
        public int? StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}
