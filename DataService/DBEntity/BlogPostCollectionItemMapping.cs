using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class BlogPostCollectionItemMapping
    {
        public int Id { get; set; }
        public int BlogPostCollectionId { get; set; }
        public int BlogPostId { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }

        public virtual BlogPost BlogPost { get; set; }
        public virtual BlogPostCollection BlogPostCollection { get; set; }
    }
}
