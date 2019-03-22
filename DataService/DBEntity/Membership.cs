using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Membership
    {
        public Membership()
        {
            Account = new HashSet<Account>();
            Card = new HashSet<Card>();
            Voucher = new HashSet<Voucher>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string Csv { get; set; }
        public bool Active { get; set; }
        public int? Status { get; set; }
        public int? Level { get; set; }
        public int? MembershipTypeId { get; set; }
        public bool? IsSample { get; set; }
        public int? StoreId { get; set; }
        public string ProductCode { get; set; }
        public double? InitialValue { get; set; }
        public string MembershipCode { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreateBy { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual MembershipType MembershipType { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<Card> Card { get; set; }
        public virtual ICollection<Voucher> Voucher { get; set; }
    }
}
