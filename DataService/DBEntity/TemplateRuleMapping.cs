using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class TemplateRuleMapping
    {
        public int Id { get; set; }
        public int? PaySlipTemplateId { get; set; }
        public int? SalaryRuleId { get; set; }
        public bool Active { get; set; }

        public virtual PaySlipTemplate PaySlipTemplate { get; set; }
        public virtual SalaryRule SalaryRule { get; set; }
    }
}
