using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class TimeFrame
    {
        public TimeFrame()
        {
            Attendance = new HashSet<Attendance>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int BrandId { get; set; }
        public int? EmployeeGroupId { get; set; }
        public TimeSpan BreakTime { get; set; }
        public bool Active { get; set; }
        public bool? IsOverTime { get; set; }
        public int? InMode { get; set; }
        public int? OutMode { get; set; }
        public int? BreakCount { get; set; }
        public TimeSpan? CheckInExpandTime { get; set; }
        public TimeSpan? CheckOutExpandTime { get; set; }
        public int? StoreFilter { get; set; }
        public TimeSpan? ComeLateExpandTime { get; set; }
        public TimeSpan? LeaveEarlyExpandTime { get; set; }

        public virtual EmployeeGroup EmployeeGroup { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
    }
}
