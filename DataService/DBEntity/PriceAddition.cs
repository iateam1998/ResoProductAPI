using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PriceAddition
    {
        public int AdditionPriceId { get; set; }
        public string EarlyHourRange { get; set; }
        public string EarlyPriceRange { get; set; }
        public string LateHourRange { get; set; }
        public string LatePriceRange { get; set; }
        public string Name { get; set; }
    }
}
