using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductBrand
    {
        public ProductBrand()
        {
            Product = new HashSet<Product>();
        }

        public int ProductBrandId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int? Count { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
