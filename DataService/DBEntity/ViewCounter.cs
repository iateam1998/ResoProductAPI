using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ViewCounter
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int OnlineCount { get; set; }
        public int TodayCount { get; set; }
        public int ThisWeekCount { get; set; }
        public int ThisMonthCount { get; set; }
        public int TotalCount { get; set; }

        public virtual Store Store { get; set; }
    }
}
