using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductDetailMapping
    {
        public int ProductDetailId { get; set; }
        public int? ProductId { get; set; }
        public int? StoreId { get; set; }
        public double? Price { get; set; }
        public double? DiscountPrice { get; set; }
        public double? DiscountPercent { get; set; }
        public bool? Active { get; set; }
        public int? SaleMethodEnum { get; set; }

        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
