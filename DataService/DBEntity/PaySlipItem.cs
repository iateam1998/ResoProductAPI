using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PaySlipItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PaySlipId { get; set; }
        public int? PayrollDetailId { get; set; }
        public double? Value { get; set; }
        public bool Active { get; set; }

        public virtual PaySlip PaySlip { get; set; }
        public virtual PayrollDetail PayrollDetail { get; set; }
    }
}
