using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PriceGroup
    {
        public PriceGroup()
        {
            Order = new HashSet<Order>();
            OrderFeeItem = new HashSet<OrderFeeItem>();
            PriceNight = new HashSet<PriceNight>();
            RoomCategoryPriceGroupMapping = new HashSet<RoomCategoryPriceGroupMapping>();
        }

        public int PriceGroupId { get; set; }
        public string PriceGroupName { get; set; }
        public DateTime StartDayTime { get; set; }
        public DateTime EndNightTime { get; set; }
        public double DayPrice { get; set; }
        public int RoundMinute { get; set; }
        public double FirstHourPrice { get; set; }
        public double SecondHourPrice { get; set; }
        public double ThirdHourPrice { get; set; }
        public double NextHourPrice { get; set; }
        public int NightAdditionPriceId { get; set; }
        public bool IsAvailable { get; set; }
        public double AdditionPrice { get; set; }
        public int DayLimitTime1 { get; set; }
        public double DayPriceLimitTime1 { get; set; }
        public int DayLimitTime2 { get; set; }
        public double DayPriceLimitTime2 { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<OrderFeeItem> OrderFeeItem { get; set; }
        public virtual ICollection<PriceNight> PriceNight { get; set; }
        public virtual ICollection<RoomCategoryPriceGroupMapping> RoomCategoryPriceGroupMapping { get; set; }
    }
}
