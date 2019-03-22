using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Room
    {
        public Room()
        {
            Order = new HashSet<Order>();
        }

        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }
        public int RoomStatus { get; set; }
        public int FloorId { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public int? StoreId { get; set; }
        public int? CurrentRentId { get; set; }
        public int? RentStatus { get; set; }
        public int PosX { get; set; }
        public int PosSpanX { get; set; }
        public int PosY { get; set; }
        public int PosSpanY { get; set; }
        public int? RentType { get; set; }
        public int? Status { get; set; }

        public virtual RoomCategory Category { get; set; }
        public virtual RoomFloor Floor { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
