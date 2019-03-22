using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class BlogPost
    {
        public BlogPost()
        {
            BlogPostCollectionItemMapping = new HashSet<BlogPostCollectionItemMapping>();
            BlogPostImage = new HashSet<BlogPostImage>();
            TagMapping = new HashSet<TagMapping>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string BlogContent { get; set; }
        public string Excerpt { get; set; }
        public int? BlogCategoryId { get; set; }
        public string PageTitle { get; set; }
        public string MetaDescription { get; set; }
        public bool Active { get; set; }
        public int StoreId { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string SeoName { get; set; }
        public string MetaKeyword { get; set; }
        public int? TotalVisit { get; set; }
        public int? BrandId { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public string TitleEn { get; set; }
        public string Opening { get; set; }
        public int? OpeningEn { get; set; }
        public string BlogContentEn { get; set; }
        public string Url { get; set; }
        public string PageTitleEn { get; set; }
        public int? Position { get; set; }
        public int? Status { get; set; }
        public string LastUpdatePerson { get; set; }
        public string Reference { get; set; }
        public string LinkRef1 { get; set; }
        public string LinkRef2 { get; set; }
        public string LinkRef3 { get; set; }
        public string LinkRef4 { get; set; }
        public string LinkRef5 { get; set; }
        public int? BlogType { get; set; }
        public int? LocationId { get; set; }
        public string AuthorRefer { get; set; }
        public string UserApprove { get; set; }
        public DateTime? PublicDate { get; set; }
        public int? BlogPostCollectionNumber { get; set; }
        public string NameEn { get; set; }
        public string DescriptionEn { get; set; }
        public string BlogCategoryIds { get; set; }
        public string TagIds { get; set; }

        public virtual BlogCategory BlogCategory { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<BlogPostCollectionItemMapping> BlogPostCollectionItemMapping { get; set; }
        public virtual ICollection<BlogPostImage> BlogPostImage { get; set; }
        public virtual ICollection<TagMapping> TagMapping { get; set; }
    }
}
