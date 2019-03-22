using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }

        public virtual Product Product { get; set; }
    }
}
