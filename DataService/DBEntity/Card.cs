using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Card
    {
        public Card()
        {
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public int IdCardType { get; set; }
        public string CardCode { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int BrandId { get; set; }
        public int MembershipId { get; set; }
        public bool Active { get; set; }
        public string CreateBy { get; set; }
        public bool? IsSample { get; set; }
        public bool? IsMobile { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Membership Membership { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
