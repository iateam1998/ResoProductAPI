using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class MembershipType
    {
        public MembershipType()
        {
            Membership = new HashSet<Membership>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string AppendCode { get; set; }
        public bool? Active { get; set; }
        public int? TypeLevel { get; set; }
        public int? TypePoint { get; set; }
        public int BrandId { get; set; }
        public bool? IsMobile { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Membership> Membership { get; set; }
    }
}
