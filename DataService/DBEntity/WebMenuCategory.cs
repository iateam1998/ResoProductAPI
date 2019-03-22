using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class WebMenuCategory
    {
        public WebMenuCategory()
        {
            WebMenu = new HashSet<WebMenu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsMenuSystem { get; set; }
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<WebMenu> WebMenu { get; set; }
    }
}
