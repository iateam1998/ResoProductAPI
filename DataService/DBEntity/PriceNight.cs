using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PriceNight
    {
        public int RoomPriceId { get; set; }
        public int PriceGroupId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Price { get; set; }
        public int MaxDuration { get; set; }
        public double PricePerHour { get; set; }
        public DateTime CheckTime { get; set; }

        public virtual PriceGroup PriceGroup { get; set; }
    }
}
