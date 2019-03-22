using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class OrderGroup
    {
        public OrderGroup()
        {
            Guest = new HashSet<Guest>();
            SubRentGroup = new HashSet<SubRentGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? CustomerId { get; set; }
        public int SourceId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime? GetRoomDate { get; set; }
        public string Note { get; set; }
        public int? StoreId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Guest> Guest { get; set; }
        public virtual ICollection<SubRentGroup> SubRentGroup { get; set; }
    }
}
