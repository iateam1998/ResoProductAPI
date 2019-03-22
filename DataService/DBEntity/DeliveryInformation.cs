using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class DeliveryInformation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public int? TypeAddress { get; set; }
        public string Address { get; set; }
        public bool? Active { get; set; }
        public bool? IsDefault { get; set; }
        public int? ProvinceCode { get; set; }
        public int? DistrictCode { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual District DistrictCodeNavigation { get; set; }
        public virtual Province ProvinceCodeNavigation { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
