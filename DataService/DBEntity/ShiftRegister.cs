using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ShiftRegister
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? TimeframeId { get; set; }
        public int? Status { get; set; }
        public bool Active { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
