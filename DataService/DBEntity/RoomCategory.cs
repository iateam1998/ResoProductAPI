using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class RoomCategory
    {
        public RoomCategory()
        {
            Room = new HashSet<Room>();
            RoomCategoryPriceGroupMapping = new HashSet<RoomCategoryPriceGroupMapping>();
            SubRentGroup = new HashSet<SubRentGroup>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string IconUrl { get; set; }
        public string ShortNane { get; set; }
        public int Priority { get; set; }
        public int? StoreId { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<Room> Room { get; set; }
        public virtual ICollection<RoomCategoryPriceGroupMapping> RoomCategoryPriceGroupMapping { get; set; }
        public virtual ICollection<SubRentGroup> SubRentGroup { get; set; }
    }
}
