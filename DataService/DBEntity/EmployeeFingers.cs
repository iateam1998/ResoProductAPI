using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class EmployeeFingers
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string EmpEnrollNumber { get; set; }
        public int FingerIndex { get; set; }
        public string FingerData { get; set; }
        public int? Type { get; set; }
        public string NameEmployeeInMachine { get; set; }
        public bool Active { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
