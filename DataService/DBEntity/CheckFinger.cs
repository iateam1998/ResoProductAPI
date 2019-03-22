using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CheckFinger
    {
        public int Id { get; set; }
        public int? FingerScanMachineId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime DateTime { get; set; }
        public int? Mode { get; set; }
        public bool Active { get; set; }
        public int? StoreId { get; set; }
        public string MachineNumber { get; set; }
        public string EmpEnrollNumber { get; set; }
        public bool? IsUpdated { get; set; }
        public int? BrandId { get; set; }
        public string LogCode { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual FingerScanMachine FingerScanMachine { get; set; }
    }
}
