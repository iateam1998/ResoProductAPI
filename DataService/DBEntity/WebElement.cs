using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class WebElement
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }
        public bool Active { get; set; }
        public int? BrandId { get; set; }

        public virtual WebElementType Parent { get; set; }
    }
}
