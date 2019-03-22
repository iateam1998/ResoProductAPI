using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class StoreWebSetting
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }

        public virtual Store Store { get; set; }
    }
}
