using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class DayMode
    {
        public DayMode()
        {
            TimeModeRule = new HashSet<TimeModeRule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DayFilter { get; set; }
        public int? IsSpecialDay { get; set; }
        public int? Priority { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TimeModeRule> TimeModeRule { get; set; }
    }
}
