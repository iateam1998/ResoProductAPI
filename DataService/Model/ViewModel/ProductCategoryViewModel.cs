using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductCategoryViewModel : BaseViewModel<ProductCategory>
    {
        public int CateId { get; set; }
        public string CateName { get; set; }
        public string CateNameEng { get; set; }
        public int Type { get; set; }
        public bool? IsDisplayed { get; set; }
        public bool IsDisplayedWebsite { get; set; }
        public bool IsExtra { get; set; }
        public int DisplayOrder { get; set; }
        public string AdjustmentNote { get; set; }
        public int? StoreId { get; set; }
        public string SeoName { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoDescription { get; set; }
        public string ImageFontAwsomeCss { get; set; }
        public int? ParentCateId { get; set; }
        public int? Position { get; set; }
        public bool? Active { get; set; }
        public int? BrandId { get; set; }
        public string PicUrl { get; set; }
        public string BannerUrl { get; set; }
        public string Description { get; set; }
        public string DescriptionEng { get; set; }
        public string BannerDescription { get; set; }
        public string BannerDescriptionEng { get; set; }
        public string Att1 { get; set; }
        public string Att2 { get; set; }
        public string Att3 { get; set; }
        public string Att4 { get; set; }
        public string Att5 { get; set; }
        public string Att6 { get; set; }
        public string Att7 { get; set; }
        public string Att8 { get; set; }
        public string Att9 { get; set; }
        public string Att10 { get; set; }
        public double? Vat { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ProductCategory ParentCate { get; set; }
        public virtual ICollection<CategoryExtraMapping> CategoryExtraMappingExtraCategory { get; set; }
        public virtual ICollection<CategoryExtraMapping> CategoryExtraMappingPrimaryCategory { get; set; }
        public virtual ICollection<ProductCategory> InverseParentCate { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
