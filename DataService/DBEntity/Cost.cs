using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Cost
    {
        public Cost()
        {
            CostInventoryMapping = new HashSet<CostInventoryMapping>();
            Payment = new HashSet<Payment>();
        }

        public int CostId { get; set; }
        public int CatId { get; set; }
        public string CostDescription { get; set; }
        public DateTime CostDate { get; set; }
        public double Amount { get; set; }
        public int CostStatus { get; set; }
        public string PaidPerson { get; set; }
        public string LoggedPerson { get; set; }
        public string ApprovedPerson { get; set; }
        public int? StoreId { get; set; }
        public int? CostCategoryType { get; set; }
        public string CostCode { get; set; }
        public int? CostType { get; set; }

        public virtual CostCategory Cat { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<CostInventoryMapping> CostInventoryMapping { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
