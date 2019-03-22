using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class StoreTheme
    {
        public int StoreThemeId { get; set; }
        public int StoreId { get; set; }
        public string ThemeName { get; set; }
        public int ThemeId { get; set; }
        public string StoreThemeName { get; set; }
        public string ThemeLogoUrl { get; set; }
        public string CustomThemeStyle { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsUsing { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }

        public virtual Store Store { get; set; }
        public virtual Theme Theme { get; set; }
    }
}
