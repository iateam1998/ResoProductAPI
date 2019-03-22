using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductImageCollection
    {
        public ProductImageCollection()
        {
            ProductImageCollectionItemMapping = new HashSet<ProductImageCollectionItemMapping>();
        }

        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<ProductImageCollectionItemMapping> ProductImageCollectionItemMapping { get; set; }
    }
}
