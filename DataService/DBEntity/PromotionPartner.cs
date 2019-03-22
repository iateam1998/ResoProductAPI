using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PromotionPartner
    {
        public PromotionPartner()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string PartnerName { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string OrderPrefix { get; set; }
        public string Token { get; set; }
        public decimal CommissionRate { get; set; }
        public int CustomerId { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
