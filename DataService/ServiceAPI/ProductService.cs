using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.ServiceAPI
{
    public interface IProductService : IBaseService<Product, ProductViewModel>
    {
        IQueryable<ProductViewModel> GetAvailableByProductCategoryId(int categoryId);
        IEnumerable<ProductViewModel> GetAllProductsByBrand(int brandId);
        ProductViewModel GetProductByProductId(int productId);
        List<ProductApiViewModel> MapProduct(IEnumerable<ProductDetailMappingViewModel> listP, int terminalId);
    }
    public class ProductService : BaseService<Product, ProductViewModel>, IProductService
    {
        private readonly IServiceProvider _serviceProvider;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IServiceProvider serviceProvider) : base(unitOfWork, mapper)
        {
            _serviceProvider = serviceProvider;
        }

        public IEnumerable<ProductViewModel> GetAllProductsByBrand(int brandId)
        {
            var result = this.GetAsNoTracking(q =>
                    q.Cat.BrandId == brandId && q.Cat.Active.Value && q.Active)
                    .ProjectTo<ProductViewModel>(Mapper.ConfigurationProvider);
            return result;
        }

        public IQueryable<ProductViewModel> GetAvailableByProductCategoryId(int categoryId)
        {
            var products = this
                .GetActiveAsNoTracking(q => q.CatId == categoryId
                && q.IsAvailable == true)
                .OrderBy(q => q.Position)
                .ProjectTo<ProductViewModel>(Mapper.ConfigurationProvider);
            return products;
        }

        public ProductViewModel GetProductByProductId(int productId)
        {
            var product = this.FirstOrDefault(q => q.ProductId == productId && q.Active == true);
            return product;
        }

        public List<ProductApiViewModel> MapProduct(IEnumerable<ProductDetailMappingViewModel> listP, int terminalId)
        {
            var productList = new List<ProductApiViewModel>();
            foreach (var item in listP)
            {
                if (item.Product != null)
                {
                    var p = new ProductApiViewModel()
                    {
                        ProductId = item.Product.ProductId,
                        ProductName = item.Product.ProductName,
                        ShortName = null,
                        Code = item.Product.Code,
                        PicURL = item.Product.PicUrl,
                        Price = item.Product.Price,
                        DiscountPercent = item.Product.DiscountPercent,
                        DiscountPrice = item.Product.DiscountPrice,
                        CatID = item.Product.CatId,
                        ProductType = item.Product.ProductType,
                        DisplayOrder = item.Product.DisplayOrder,
                        IsMenuDisplay = true,
                        IsAvailable = item.Product.IsAvailable,
                        PosX = (int)item.Product.PosX.GetValueOrDefault(),
                        PosY = (int)item.Product.PosY.GetValueOrDefault(),
                        ColorGroup = item.Product.ColorGroup,
                        Group = (int)item.Product.Group.GetValueOrDefault(),
                        GeneralProductId = item.Product.GeneralProductId,
                        Att1 = item.Product.Att1,
                        Att2 = item.Product.Att2,
                        Att3 = item.Product.Att3,
                        MaxExtra = 0,
                        IsUsed = true,
                        HasExtra = false,
                        IsFixedPrice = item.Product.IsFixedPrice,
                        IsDefaultChildProduct = item.Product.IsDefaultChildProduct == (int)SaleTypeEnum.DefaultNothing ? false : true,
                        IsMostOrder = item.Product.IsMostOrdered,

                        Category = new ProductCategoryApiViewModel()

                        {
                            Code = item.Product.CatId,
                            Name = item.Product.Cat.CateName,
                            Type = item.Product.Cat.Type,
                            DisplayOrder = item.Product.Cat.DisplayOrder,
                            IsExtra = item.Product.Cat.IsExtra ? 1 : 0,
                            IsDisplayed = item.Product.Cat.IsDisplayed.Value,
                            IsUsed = true,
                            AdjustmentNote = item.Product.Cat.AdjustmentNote,
                            ImageFontAwsomeCss = item.Product.Cat.ImageFontAwsomeCss,
                            ParentCateId = item.Product.Cat.ParentCateId
                        }
                    };
                    if (p.IsFixedPrice == false)
                    {
                        var _productDetailMappingService = ServiceFactory.CreateService<IProductDetailMappingService>(_serviceProvider);
                        var priceProduct = _productDetailMappingService.GetPriceByStore(terminalId, item.Product.ProductId);
                        if (priceProduct != 0)
                        {
                            p.Price = priceProduct;
                        }
                        else
                        {
                            p.Price = item.Product.Price;
                        }

                        var discountProduct = _productDetailMappingService.GetDiscountByStore(terminalId, item.Product.ProductId);
                        if (priceProduct != 0)
                        {
                            p.DiscountPercent = discountProduct;
                        }
                        else
                        {
                            p.DiscountPercent = item.Product.DiscountPercent;
                        }

                    }
                    productList.Add(p);
                }
            }
            return productList;
        }
    }
}
