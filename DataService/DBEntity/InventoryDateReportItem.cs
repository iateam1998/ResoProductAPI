using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class InventoryDateReportItem
    {
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public int ReportId { get; set; }
        public double? ImportAmount { get; set; }
        public double? ExportAmount { get; set; }
        public double? CancelAmount { get; set; }
        public double? SoldAmount { get; set; }
        public double? ReturnAmount { get; set; }
        public double? ChangeInventoryAmount { get; set; }
        public double? TheoryAmount { get; set; }
        public double? RealAmount { get; set; }
        public double? TotalExport { get; set; }
        public double? TotalImport { get; set; }
        public double? ReceivedChangeInventoryAmount { get; set; }
        public bool? IsSelected { get; set; }
        public double Price { get; set; }

        public virtual ProductItem Item { get; set; }
        public virtual InventoryDateReport Report { get; set; }
    }
}
