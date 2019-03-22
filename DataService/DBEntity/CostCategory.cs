using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CostCategory
    {
        public CostCategory()
        {
            Cost = new HashSet<Cost>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public int? Type { get; set; }
        public bool? Active { get; set; }
        public int? BrandId { get; set; }

        public virtual ICollection<Cost> Cost { get; set; }
    }
}
