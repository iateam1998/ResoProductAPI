using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Group
    {
        public Group()
        {
            Store = new HashSet<Store>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDisplayed { get; set; }
        public int BrandId { get; set; }

        public virtual ICollection<Store> Store { get; set; }
    }
}
