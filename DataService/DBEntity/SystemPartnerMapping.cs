using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class SystemPartnerMapping
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public int StoreId { get; set; }
        public int BrandId { get; set; }
        public string Att1 { get; set; }
        public string Att2 { get; set; }
        public string Att3 { get; set; }
        public string Att4 { get; set; }
    }
}
