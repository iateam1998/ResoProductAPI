using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ReportTracking
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UpdatePerson { get; set; }
        public bool? IsUpdate { get; set; }

        public virtual Store Store { get; set; }
    }
}
