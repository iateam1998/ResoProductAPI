using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class StoreWebViewCounter
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int WeeklyViewCount { get; set; }
        public int MonthlyViewCount { get; set; }
        public int TotalViewCount { get; set; }
        public DateTime LastUpdate { get; set; }
        public int TodayViewCount { get; set; }
        public int YearlyViewCount { get; set; }
        public bool Active { get; set; }

        public virtual Store Store { get; set; }
    }
}
