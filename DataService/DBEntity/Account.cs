using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Account
    {
        public Account()
        {
            Payment = new HashSet<Payment>();
            Transaction = new HashSet<Transaction>();
        }

        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public short Level { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public decimal? Balance { get; set; }
        public string ProductCode { get; set; }
        public int? MembershipId { get; set; }
        public int? Type { get; set; }
        public int? BrandId { get; set; }
        public bool? Active { get; set; }
        public int? CustomerId { get; set; }
        public int Policy { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Membership Membership { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
