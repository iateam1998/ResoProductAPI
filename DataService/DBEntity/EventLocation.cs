using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class EventLocation
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public bool Active { get; set; }
    }
}
