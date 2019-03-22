using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class WebMenu
    {
        public WebMenu()
        {
            InverseParentMenu = new HashSet<WebMenu>();
        }

        public int Id { get; set; }
        public string MenuText { get; set; }
        public string MenuText1 { get; set; }
        public string MenuText2 { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
        public string IconUrl { get; set; }
        public int DisplayOrder { get; set; }
        public int? ParentMenuId { get; set; }
        public int? MenuLevel { get; set; }
        public int? StoreFilter { get; set; }
        public bool? Active { get; set; }
        public bool IsSystemMenu { get; set; }
        public int CategoryId { get; set; }

        public virtual WebMenuCategory Category { get; set; }
        public virtual WebMenu ParentMenu { get; set; }
        public virtual ICollection<WebMenu> InverseParentMenu { get; set; }
    }
}
