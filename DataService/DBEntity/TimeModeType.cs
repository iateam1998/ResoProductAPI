using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class TimeModeType
    {
        public TimeModeType()
        {
            TimeModeRule = new HashSet<TimeModeRule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TimeModeRule> TimeModeRule { get; set; }
    }
}
