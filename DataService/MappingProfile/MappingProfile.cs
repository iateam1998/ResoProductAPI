using AutoMapper;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.MappingProfileModel
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ///<summary>
            /// Mapping Object <=> View Model
            /// </summary>
            this.CreateMap<Product, ProductViewModel>();
            this.CreateMap<ProductViewModel, Product>();

            this.CreateMap<ProductItem, ProductItemViewModel>();
            this.CreateMap<ProductItemViewModel, ProductItem>();

            this.CreateMap<ProductItemCompositionMapping, ProductItemCompositionMappingViewModel>();
            this.CreateMap<ProductItemCompositionMappingViewModel, ProductItemCompositionMapping>();

            this.CreateMap<ProductCategory, ProductCategoryViewModel>();
            this.CreateMap<ProductCategoryViewModel, ProductCategory>();

            this.CreateMap<ProductItemCategory, ProductItemCategoryViewModel>();
            this.CreateMap<ProductItemCategoryViewModel, ProductItemCategory>();

            this.CreateMap<ProductImage, ProductImageViewModel>();
            this.CreateMap<ProductImageViewModel, ProductImage>();

            this.CreateMap<ProductComboDetail, ProductComboDetailViewModel>();
            this.CreateMap<ProductComboDetailViewModel, ProductComboDetail>();

            this.CreateMap<Store, StoreViewModel>();
            this.CreateMap<StoreViewModel, Store>();

            this.CreateMap<ProductDetailMapping, ProductDetailMappingViewModel>();
            this.CreateMap<ProductDetailMappingViewModel, ProductDetailMapping>();

            this.CreateMap<CategoryExtraMapping, CategoryExtraMappingViewModel>();
            this.CreateMap<CategoryExtraMappingViewModel, CategoryExtraMapping>();
            // For Missing Type
            this.AllowNullCollections = true;
            this.AllowNullDestinationValues = true;
            this.CreateMissingTypeMaps = true;
        }
    }
}
