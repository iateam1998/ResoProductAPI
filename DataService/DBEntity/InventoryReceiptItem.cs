using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class InventoryReceiptItem
    {
        public int ReceiptId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public DateTime? DateExpired { get; set; }
        public DateTime? ExportedDate { get; set; }
        public bool? IsUnit1 { get; set; }

        public virtual ProductItem Item { get; set; }
        public virtual InventoryReceipt Receipt { get; set; }
    }
}
