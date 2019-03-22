using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PaySlipTemplate
    {
        public PaySlipTemplate()
        {
            PayrollPeriod = new HashSet<PayrollPeriod>();
            TemplateDetailMapping = new HashSet<TemplateDetailMapping>();
            TemplateRuleMapping = new HashSet<TemplateRuleMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int BrandId { get; set; }

        public virtual ICollection<PayrollPeriod> PayrollPeriod { get; set; }
        public virtual ICollection<TemplateDetailMapping> TemplateDetailMapping { get; set; }
        public virtual ICollection<TemplateRuleMapping> TemplateRuleMapping { get; set; }
    }
}
