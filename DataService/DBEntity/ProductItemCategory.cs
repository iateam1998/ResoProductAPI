using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductItemCategory
    {
        public ProductItemCategory()
        {
            ProductItem = new HashSet<ProductItem>();
        }

        public int CateId { get; set; }
        public string CateName { get; set; }
        public int Type { get; set; }
        public int? BrandId { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<ProductItem> ProductItem { get; set; }
    }
}
