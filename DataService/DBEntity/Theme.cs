using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Theme
    {
        public Theme()
        {
            StoreTheme = new HashSet<StoreTheme>();
        }

        public int ThemeId { get; set; }
        public string ThemeName { get; set; }
        public string ThemeFolderUrl { get; set; }
        public string ThemeStyle { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }

        public virtual ICollection<StoreTheme> StoreTheme { get; set; }
    }
}
