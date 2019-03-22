using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Rating
    {
        public Rating()
        {
            InverseParent = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public int? ProductId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? Star { get; set; }
        public string ReviewContent { get; set; }
        public bool Active { get; set; }
        public string ReviewEmail { get; set; }
        public string ReviewName { get; set; }
        public bool? Verified { get; set; }
        public int? Rate1 { get; set; }
        public int? Rate2 { get; set; }
        public int? Rate3 { get; set; }
        public int? Rate4 { get; set; }
        public int? Rate5 { get; set; }
        public int? CustomerId { get; set; }
        public int? OrderId { get; set; }
        public int? StoreId { get; set; }
        public int? ParentId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
        public virtual Rating Parent { get; set; }
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<Rating> InverseParent { get; set; }
    }
}
