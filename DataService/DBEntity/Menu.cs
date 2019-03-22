using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Menu
    {
        public Menu()
        {
            InverseParentMenu = new HashSet<Menu>();
            MenuRole = new HashSet<MenuRole>();
        }

        public int Id { get; set; }
        public string MenuText { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string IconCss { get; set; }
        public int DisplayOrder { get; set; }
        public int? ParentMenuId { get; set; }
        public int MenuLevel { get; set; }
        public bool Status { get; set; }
        public int MenuTypeCode { get; set; }
        public int? FeatureCode { get; set; }
        public int? MenuState { get; set; }
        public int? MenuUrlCode { get; set; }

        public virtual Menu ParentMenu { get; set; }
        public virtual ICollection<Menu> InverseParentMenu { get; set; }
        public virtual ICollection<MenuRole> MenuRole { get; set; }
    }
}
