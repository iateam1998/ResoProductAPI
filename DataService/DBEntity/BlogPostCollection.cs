using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class BlogPostCollection
    {
        public BlogPostCollection()
        {
            BlogPostCollectionItem = new HashSet<BlogPostCollectionItem>();
            BlogPostCollectionItemMapping = new HashSet<BlogPostCollectionItemMapping>();
            InverseParent = new HashSet<BlogPostCollection>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SeoName { get; set; }
        public int StoreId { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string SeoDescription { get; set; }
        public string Link { get; set; }
        public string PicUrl { get; set; }
        public int? ParentId { get; set; }
        public string NameEn { get; set; }
        public string DescriptionEn { get; set; }
        public bool? IsDisplay { get; set; }
        public int? Position { get; set; }
        public string SeoKeyword { get; set; }
        public int? Limitation { get; set; }
        public int? BrandId { get; set; }
        public string SeoName1 { get; set; }

        public virtual BlogPostCollection Parent { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<BlogPostCollectionItem> BlogPostCollectionItem { get; set; }
        public virtual ICollection<BlogPostCollectionItemMapping> BlogPostCollectionItemMapping { get; set; }
        public virtual ICollection<BlogPostCollection> InverseParent { get; set; }
    }
}
