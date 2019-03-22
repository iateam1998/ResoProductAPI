using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class SalaryHour
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double? Duration { get; set; }
        public int InsertMode { get; set; }
        public int? EmployeeId { get; set; }
        public string UpdatePerson { get; set; }
        public int? TimeModeRuleId { get; set; }
        public string ExistCode { get; set; }
        public bool Active { get; set; }
    }
}
