using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductViewModel : BaseViewModel<Product>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductNameEng { get; set; }
        public double Price { get; set; }
        public string PicUrl { get; set; }
        public int CatId { get; set; }
        public bool IsAvailable { get; set; }
        public string Code { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountPrice { get; set; }
        public int ProductType { get; set; }
        public int DisplayOrder { get; set; }
        public bool HasExtra { get; set; }
        public bool IsFixedPrice { get; set; }
        public int? PosX { get; set; }
        public int? PosY { get; set; }
        public int? ColorGroup { get; set; }
        public int? Group { get; set; }
        public int? GroupId { get; set; }
        public bool? IsMenuDisplay { get; set; }
        public int? GeneralProductId { get; set; }
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
        public int? MaxExtra { get; set; }
        public string Description { get; set; }
        public string DescriptionEng { get; set; }
        public string Introduction { get; set; }
        public string IntroductionEng { get; set; }
        public int? PrintGroup { get; set; }
        public string SeoName { get; set; }
        public int? IsHomePage { get; set; }
        public string WebContent { get; set; }
        public string SeoKeyWords { get; set; }
        public string SeoDescription { get; set; }
        public bool Active { get; set; }
        public int IsDefaultChildProduct { get; set; }
        public int? Position { get; set; }
        public int? SaleType { get; set; }
        public bool IsMostOrdered { get; set; }
        public string Note { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? RatingTotal { get; set; }
        public int? NumOfUserVoted { get; set; }
        public int? Status { get; set; }
        public int? SaleMethodEnum { get; set; }
        public string AlterNativeCode { get; set; }
        public double? PriceCogs { get; set; }
        public int? ProductBrandId { get; set; }
        public string CateIds { get; set; }
        public string TagIds { get; set; }
        public string ProRelatedIds { get; set; }
        public string MetaDataIds { get; set; }
        public bool? OnSale { get; set; }
        public double? SalePrice { get; set; }
        public int? Stock { get; set; }
        public bool? ReviewAllow { get; set; }
        public string AverageRating { get; set; }
        public bool? IsAllowFreeShip { get; set; }
        public string ProVideoUrl { get; set; }
        public string ShortDecription { get; set; }
        public string ShortDecriptionEng { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Volume { get; set; }
        public string Weight { get; set; }
        public DateTime? AvailableDate { get; set; }

        public virtual ProductCategory Cat { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }
        public virtual ICollection<CustomerProductMapping> CustomerProductMapping { get; set; }
        public virtual ICollection<DateProduct> DateProduct { get; set; }
        public virtual ICollection<Favorited> Favorited { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<ProductCollectionItemMapping> ProductCollectionItemMapping { get; set; }
        public virtual ICollection<ProductComboDetailViewModel> ProductComboDetailCombo { get; set; }
        public virtual ICollection<ProductComboDetailViewModel> ProductComboDetailProduct { get; set; }
        public virtual ICollection<ProductDetailMapping> ProductDetailMapping { get; set; }
        public virtual ICollection<ProductImageViewModel> ProductImage { get; set; }
        public virtual ICollection<ProductItemCompositionMapping> ProductItemCompositionMapping { get; set; }
        public virtual ICollection<ProductSpecification> ProductSpecification { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }

        public double? DiscountPriceEdit
        {
            get
            {
                return this.DiscountPrice;
            }
            set
            {
                if (value.HasValue)
                {
                    this.DiscountPrice = value.Value;
                }
                else
                {
                    this.DiscountPrice = 0;
                }
            }
        }

        public string FormattedDiscountPrice
        {
            get
            {
                if (this.Price == 0)
                {
                    return null;
                }
                else
                {
                    return this.DiscountPrice.ToString("#,#.#");
                }
            }
        }

        public double PrimaryPrice
        {
            get
            {
                if (this.Price != 0 && this.DiscountPrice != 0)
                {
                    return this.DiscountPrice;
                }
                return this.Price;
            }
        }

        public string FormattedPrice
        {
            get
            {
                if (this.Price == 0)
                {
                    return null;
                }
                else
                {
                    return this.Price.ToString("#,#.#");
                }
            }
        }
    }
}
