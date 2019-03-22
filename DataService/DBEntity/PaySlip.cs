using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PaySlip
    {
        public PaySlip()
        {
            PaySlipItem = new HashSet<PaySlipItem>();
            PayslipAttributeMapping = new HashSet<PayslipAttributeMapping>();
        }

        public int Id { get; set; }
        public int? PayrollPeriodId { get; set; }
        public int? EmployeeId { get; set; }
        public int? TemplateDetailMappingId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public double? FinalPaid { get; set; }
        public bool Active { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual PayrollPeriod PayrollPeriod { get; set; }
        public virtual TemplateDetailMapping TemplateDetailMapping { get; set; }
        public virtual ICollection<PaySlipItem> PaySlipItem { get; set; }
        public virtual ICollection<PayslipAttributeMapping> PayslipAttributeMapping { get; set; }
    }
}
