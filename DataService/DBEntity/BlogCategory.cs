using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class BlogCategory
    {
        public BlogCategory()
        {
            BlogPost = new HashSet<BlogPost>();
            TagMapping = new HashSet<TagMapping>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string FeedburnerUrl { get; set; }
        public string PageTitle { get; set; }
        public string MetaDescription { get; set; }
        public string UrlHandle { get; set; }
        public string IsAllowComment { get; set; }
        public int StoreId { get; set; }
        public bool IsActive { get; set; }
        public string Feedburner { get; set; }
        public int BrandId { get; set; }
        public bool? IsDisplay { get; set; }
        public int? ParentCateId { get; set; }
        public int? Type { get; set; }
        public int? Position { get; set; }
        public string BlogCateName { get; set; }
        public string BlogCateNameEn { get; set; }
        public string PageTitleEn { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public string SeoName { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoDescription { get; set; }
        public string ImageFontAwsomeCss { get; set; }
        public int? PositionTopicHomePage { get; set; }
        public string PicUrl { get; set; }
        public string BannerUrl { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<BlogPost> BlogPost { get; set; }
        public virtual ICollection<TagMapping> TagMapping { get; set; }
    }
}
