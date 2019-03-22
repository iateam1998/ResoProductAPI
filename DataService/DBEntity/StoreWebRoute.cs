using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class StoreWebRoute
    {
        public StoreWebRoute()
        {
            InverseStoreWebRouteCopy = new HashSet<StoreWebRoute>();
            StoreWebRouteModel = new HashSet<StoreWebRouteModel>();
        }

        public int Id { get; set; }
        public int StoreId { get; set; }
        public int? StoreWebRouteCopyId { get; set; }
        public string Path { get; set; }
        public string ViewName { get; set; }
        public string LayoutName { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }

        public virtual Store Store { get; set; }
        public virtual StoreWebRoute StoreWebRouteCopy { get; set; }
        public virtual ICollection<StoreWebRoute> InverseStoreWebRouteCopy { get; set; }
        public virtual ICollection<StoreWebRouteModel> StoreWebRouteModel { get; set; }
    }
}
