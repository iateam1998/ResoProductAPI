using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class WebElementType
    {
        public WebElementType()
        {
            WebElement = new HashSet<WebElement>();
        }

        public int Id { get; set; }
        public int? WebElementId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Template { get; set; }
        public int? Position { get; set; }
        public bool? ShowOnContentPage { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }
        public int? BrandId { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<WebElement> WebElement { get; set; }
    }
}
