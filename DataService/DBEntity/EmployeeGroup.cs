using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class EmployeeGroup
    {
        public EmployeeGroup()
        {
            Employee = new HashSet<Employee>();
            TimeFrame = new HashSet<TimeFrame>();
        }

        public int Id { get; set; }
        public string CodeGroup { get; set; }
        public string NameGroup { get; set; }
        public TimeSpan? ExpandTime { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }
        public int? GroupSecurity { get; set; }
        public int? GroupPolicy { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<TimeFrame> TimeFrame { get; set; }
    }
}
