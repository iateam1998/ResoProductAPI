using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PayrollDetail
    {
        public PayrollDetail()
        {
            PaySlipItem = new HashSet<PaySlipItem>();
            TemplateDetailMapping = new HashSet<TemplateDetailMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
        public int? PayrollCategoryId { get; set; }
        public bool Active { get; set; }
        public int BrandId { get; set; }

        public virtual PayrollCategory PayrollCategory { get; set; }
        public virtual ICollection<PaySlipItem> PaySlipItem { get; set; }
        public virtual ICollection<TemplateDetailMapping> TemplateDetailMapping { get; set; }
    }
}
