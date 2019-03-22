using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProviderProductItemMapping
    {
        public int ProviderProductItemId { get; set; }
        public int ProviderId { get; set; }
        public int ProductItemId { get; set; }
        public bool Active { get; set; }

        public virtual ProductItem ProductItem { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
