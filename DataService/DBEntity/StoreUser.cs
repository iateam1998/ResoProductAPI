using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class StoreUser
    {
        public string Username { get; set; }
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}
