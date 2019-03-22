using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class TagMapping
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int CategoryId { get; set; }
        public int TagBlogId { get; set; }

        public virtual BlogCategory Category { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual BlogPost TagBlog { get; set; }
    }
}
