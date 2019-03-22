using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductCollection
    {
        public ProductCollection()
        {
            ProductCollectionItemMapping = new HashSet<ProductCollectionItemMapping>();
        }

        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string NameEng { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string DescriptionEng { get; set; }
        public string Seo { get; set; }
        public string Seodescription { get; set; }
        public string Seokeyword { get; set; }
        public string Link { get; set; }
        public string BannerUrl { get; set; }
        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<ProductCollectionItemMapping> ProductCollectionItemMapping { get; set; }
    }
}
