using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Tag
    {
        public Tag()
        {
            TagMapping = new HashSet<TagMapping>();
        }

        public int Id { get; set; }
        public string TagName { get; set; }
        public string TagNameEn { get; set; }
        public long? TagViews { get; set; }
        public bool? TagActive { get; set; }
        public string Type { get; set; }

        public virtual ICollection<TagMapping> TagMapping { get; set; }
    }
}
