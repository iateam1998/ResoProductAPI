using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class TimeModeRule
    {
        public TimeModeRule()
        {
            SalaryRule = new HashSet<SalaryRule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan? StartHour { get; set; }
        public TimeSpan? EndHour { get; set; }
        public double? MinDuration { get; set; }
        public double? MaxDuration { get; set; }
        public int? DayModeId { get; set; }
        public int? TimeModeTypeId { get; set; }
        public double? DefaultRate { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }

        public virtual DayMode DayMode { get; set; }
        public virtual TimeModeType TimeModeType { get; set; }
        public virtual ICollection<SalaryRule> SalaryRule { get; set; }
    }
}
