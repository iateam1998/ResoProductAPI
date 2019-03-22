using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PartnerMapping
    {
        public int BrandId { get; set; }
        public int PartnerId { get; set; }
        public string Config { get; set; }
        public bool? Status { get; set; }
        public bool? Active { get; set; }
        public int Id { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Partner Partner { get; set; }
    }
}
