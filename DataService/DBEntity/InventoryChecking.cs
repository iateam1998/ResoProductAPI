using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class InventoryChecking
    {
        public InventoryChecking()
        {
            InventoryCheckingItem = new HashSet<InventoryCheckingItem>();
        }

        public int CheckingId { get; set; }
        public int StoreId { get; set; }
        public DateTime CheckingDate { get; set; }
        public string Creator { get; set; }
        public int Status { get; set; }

        public virtual ICollection<InventoryCheckingItem> InventoryCheckingItem { get; set; }
    }
}
