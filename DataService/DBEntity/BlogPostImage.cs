using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class BlogPostImage
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }
        public string Type { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string SizeType { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string MimeType { get; set; }
        public string Slug { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}
