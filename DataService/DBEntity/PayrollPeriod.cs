using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PayrollPeriod
    {
        public PayrollPeriod()
        {
            PaySlip = new HashSet<PaySlip>();
        }

        public int Id { get; set; }
        public int? PaySlipTemplateId { get; set; }
        public string Name { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual PaySlipTemplate PaySlipTemplate { get; set; }
        public virtual ICollection<PaySlip> PaySlip { get; set; }
    }
}
