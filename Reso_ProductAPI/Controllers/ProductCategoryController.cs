using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService;
using DataService.ServiceAPI;
using DataService.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Reso_ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        IUtils _utils;
        private readonly IServiceProvider _serviceProvider;
        public ProductCategoryController(IUtils utils, IServiceProvider serviceProvider)
        {
            _utils = utils;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Get Category Of Store
        /// </summary>
        /// <param name="token">Valid token (Required)</param>
        /// <param name="storeid">Store Id (Required)</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{token}/{storeid}")]
        public IActionResult GetCategoryList(string token, int storeid)
        {
            var _productCatogoryService = ServiceFactory.CreateService<IProductCategoryService>(_serviceProvider);
            var _catogoryExtraService = ServiceFactory.CreateService<ICategoryExtraMappingService>(_serviceProvider);
            var _storeService = ServiceFactory.CreateService<IStoreService>(_serviceProvider);

            bool check = _utils.CheckToken(token);
            if (check)
            {
                var categoryList = new List<ProductCategoryViewModel>();
                var cateExtraList = new List<CategoryExtraMappingApiViewModel>();
                var productCategoryList = new List<ProductCategoryApiViewModel>();

                var store = _storeService.GetStoreByIdSync(storeid);
                var categories = _productCatogoryService.GetProductCategoriesByBrandId((int)store.BrandId).ToList();
                var categoriesExtra = _catogoryExtraService.GetCategoryExtraMappings();

                foreach (var item in categories)
                {
                    cateExtraList.AddRange(item.CategoryExtraMappingExtraCategory.Select(a => new CategoryExtraMappingApiViewModel()
                    {
                        Id = a.Id,
                        PrimaryCategoryId = a.PrimaryCategoryId,
                        ExtraCategoryId = a.ExtraCategoryId,
                        IsEnable = a.IsEnable
                    }));
                    var category = new ProductCategoryApiViewModel()
                    {
                        Code = item.CateId,
                        Name = item.CateName,
                        Type = item.Type,
                        DisplayOrder = item.DisplayOrder,
                        IsExtra = item.IsExtra ? 1 : 0,
                        IsDisplayed = item.IsDisplayed.Value,
                        IsUsed = true,
                        AdjustmentNote = item.AdjustmentNote,
                        ImageFontAwsomeCss = item.ImageFontAwsomeCss,
                        ParentCateId = item.ParentCateId
                    };
                    productCategoryList.Add(category);
                }
                var model = new ProductCategoryExtraMappingViewModel()
                {
                    ProductCategory = productCategoryList,
                    CategoryExtra = cateExtraList,
                };
                return Ok(model);
            }
            return BadRequest("Invalid Token!");
        }
    }
}