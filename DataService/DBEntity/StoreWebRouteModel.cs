using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class StoreWebRouteModel
    {
        public int Id { get; set; }
        public int StoreWebRouteId { get; set; }
        public string Name { get; set; }
        public int ViewModelType { get; set; }
        public string IdRouteValueName { get; set; }
        public string IdRouteDefaultValue { get; set; }
        public bool Active { get; set; }

        public virtual StoreWebRoute StoreWebRoute { get; set; }
    }
}
