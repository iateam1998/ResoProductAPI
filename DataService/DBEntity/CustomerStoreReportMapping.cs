using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CustomerStoreReportMapping
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int? TotalOrder { get; set; }
        public double? TotalAmount { get; set; }
        public double? AverageAmount { get; set; }
        public int? VisitAmount { get; set; }
        public int? DateAmount { get; set; }
        public double? Frequency { get; set; }
        public DateTime LastVisitDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
    }
}
