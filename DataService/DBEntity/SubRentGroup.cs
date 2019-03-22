using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class SubRentGroup
    {
        public SubRentGroup()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int Quantity { get; set; }
        public int? ServicedQuantity { get; set; }
        public int RentGroupId { get; set; }
        public int? Status { get; set; }
        public int? SourceId { get; set; }

        public virtual OrderGroup RentGroup { get; set; }
        public virtual RoomCategory RoomTypeNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
