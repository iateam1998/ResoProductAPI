using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductSpecification
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string ImageUrl { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }

        public virtual Product Product { get; set; }
    }
}
