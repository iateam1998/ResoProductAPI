using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class TemplateDetailMapping
    {
        public TemplateDetailMapping()
        {
            PaySlip = new HashSet<PaySlip>();
        }

        public int Id { get; set; }
        public int PaySlipTemplateId { get; set; }
        public int? PayrollDetailId { get; set; }
        public bool Active { get; set; }

        public virtual PaySlipTemplate PaySlipTemplate { get; set; }
        public virtual PayrollDetail PayrollDetail { get; set; }
        public virtual ICollection<PaySlip> PaySlip { get; set; }
    }
}
