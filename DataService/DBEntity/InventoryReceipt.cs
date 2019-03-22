using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class InventoryReceipt
    {
        public InventoryReceipt()
        {
            CostInventoryMapping = new HashSet<CostInventoryMapping>();
            InventoryReceiptItem = new HashSet<InventoryReceiptItem>();
        }

        public int ReceiptId { get; set; }
        public DateTime ChangeDate { get; set; }
        public int ReceiptType { get; set; }
        public int Status { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public int? StoreId { get; set; }
        public int? InStoreId { get; set; }
        public int? OutStoreId { get; set; }
        public int? ProviderId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string InvoiceNumber { get; set; }
        public double? Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Store InStore { get; set; }
        public virtual Store OutStore { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<CostInventoryMapping> CostInventoryMapping { get; set; }
        public virtual ICollection<InventoryReceiptItem> InventoryReceiptItem { get; set; }
    }
}
