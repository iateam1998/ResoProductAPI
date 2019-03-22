using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Partner
    {
        public Partner()
        {
            PartnerMapping = new HashSet<PartnerMapping>();
        }

        public int Id { get; set; }
        public string PartnerCode { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerType { get; set; }
        public string AvatarUrl { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string SchemaConfig { get; set; }
        public bool? Active { get; set; }
        public string PartnerAddress { get; set; }

        public virtual ICollection<PartnerMapping> PartnerMapping { get; set; }
    }
}
