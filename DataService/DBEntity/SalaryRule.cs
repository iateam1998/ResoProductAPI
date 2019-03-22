using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class SalaryRule
    {
        public SalaryRule()
        {
            TemplateRuleMapping = new HashSet<TemplateRuleMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? TimeModeRuleId { get; set; }
        public double MinTimeDuration { get; set; }
        public double MaxTimeDuration { get; set; }
        public double? Value { get; set; }
        public double? Rate { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }

        public virtual TimeModeRule TimeModeRule { get; set; }
        public virtual ICollection<TemplateRuleMapping> TemplateRuleMapping { get; set; }
    }
}
