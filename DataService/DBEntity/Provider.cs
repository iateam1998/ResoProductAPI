using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Provider
    {
        public Provider()
        {
            InventoryReceipt = new HashSet<InventoryReceipt>();
            ProviderProductItemMapping = new HashSet<ProviderProductItemMapping>();
            Vatorder = new HashSet<Vatorder>();
        }

        public int Id { get; set; }
        public string ProviderName { get; set; }
        public bool? IsAvailable { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ManagerName { get; set; }
        public string License { get; set; }
        public int? BrandId { get; set; }
        public int? Type { get; set; }
        public string Vatcode { get; set; }
        public string AccountNo { get; set; }

        public virtual ICollection<InventoryReceipt> InventoryReceipt { get; set; }
        public virtual ICollection<ProviderProductItemMapping> ProviderProductItemMapping { get; set; }
        public virtual ICollection<Vatorder> Vatorder { get; set; }
    }
}
