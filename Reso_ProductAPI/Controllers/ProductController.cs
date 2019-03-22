using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService;
using DataService.DBEntity;
using DataService.ServiceAPI;
using DataService.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Reso_ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;
        IUtils _utils;
        public ProductController(IUtils utils, IServiceProvider serviceProvider)
        {
            _utils = utils;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Get Product From Store
        /// </summary>
        /// <param name="token">Token (Required)</param>
        /// <param name="storeId">Store Id (Required)</param>
        /// <param name="categoryId">Category Id (Required)</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{token}/{storeId}")]
        public IActionResult GetProduct(string token, int storeId, [FromQuery] int? categoryId)
        {
            bool check = _utils.CheckToken(token);
            var _productService = ServiceFactory.CreateService<IProductService>(_serviceProvider);
            var _storeService = ServiceFactory.CreateService<IStoreService>(_serviceProvider);
            var _productDetailMappingService = ServiceFactory.CreateService<IProductDetailMappingService>(_serviceProvider);
            if (check)
            {
                var productList = new List<ProductApiViewModel>();
                var store = _storeService.GetStoreByIdSync(storeId);
                var listProducts = _productDetailMappingService.GetProductByStoreID(storeId, store.BrandId.Value)
                    .Where(w => (categoryId == null || w.Product.CatId == categoryId));
                try
                {
                    productList = MapProduct(listProducts, storeId);
                }
                catch (Exception e)
                {
                    return NotFound(e.Message);
                }
                return Ok(productList);
            }
            return BadRequest("Invalid Token!");
        }



        private List<ProductApiViewModel> MapProduct(IEnumerable<ProductDetailMappingViewModel> listP, int terminalId)
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