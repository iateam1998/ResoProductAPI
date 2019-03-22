using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductImageCollectionItemMapping
    {
        public int Id { get; set; }
        public int ImageCollectionId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public bool Active { get; set; }
        public int Position { get; set; }

        public virtual ProductImageCollection ImageCollection { get; set; }
    }
}
