using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PromotionStoreMapping
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public int StoreId { get; set; }
        public bool Active { get; set; }

        public virtual Promotion Promotion { get; set; }
        public virtual Store Store { get; set; }
    }
}
