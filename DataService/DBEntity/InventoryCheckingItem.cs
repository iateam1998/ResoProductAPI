using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class InventoryCheckingItem
    {
        public int InventoryCheckingId { get; set; }
        public int ItemId { get; set; }
        public int CheckingId { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double? Price { get; set; }

        public virtual InventoryChecking Checking { get; set; }
    }
}
