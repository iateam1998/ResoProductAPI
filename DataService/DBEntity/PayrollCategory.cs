using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PayrollCategory
    {
        public PayrollCategory()
        {
            PayrollDetail = new HashSet<PayrollDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Mode { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<PayrollDetail> PayrollDetail { get; set; }
    }
}
