using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CostInventoryMapping
    {
        public int CostId { get; set; }
        public int ReceiptId { get; set; }
        public int? StoreId { get; set; }
        public int? ProviderId { get; set; }

        public virtual Cost Cost { get; set; }
        public virtual InventoryReceipt Receipt { get; set; }
    }
}
