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
        /// <param name="categoryId">Category Id</param>
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
                    productList = _productService.MapProduct(listProducts, storeId);
                }
                catch (Exception e)
                {
                    return NotFound(e.Message);
                }
                return Ok(productList);
            }
            return BadRequest("Invalid Token!");
        }

        /// <summary>
        /// Get Product From Store
        /// </summary>
        /// <param name="token">Token (Required)</param>
        /// <param name="storeId">Store Id (Required)</param>
        /// <param name="productId">Product Id (Required)</param>
        /// <param name="categoryId">Category Id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{token}/{storeId}/{productId}")]
        public IActionResult GetProductByProductId(string token, int storeId, int productId, [FromQuery] int? categoryId)
        {
            bool check = _utils.CheckToken(token);
            var _productService = ServiceFactory.CreateService<IProductService>(_serviceProvider);
            var _storeService = ServiceFactory.CreateService<IStoreService>(_serviceProvider);
            var _productDetailMappingService = ServiceFactory.CreateService<IProductDetailMappingService>(_serviceProvider);
            if (check)
            {
                var productList = new List<ProductApiViewModel>();
                var store = _storeService.GetStoreByIdSync(storeId);
                var result = new ProductApiViewModel();
                var listProducts = _productDetailMappingService.GetProductByStoreID(storeId, store.BrandId.Value)
                    .Where(w => (categoryId == null || w.Product.CatId == categoryId));
                try
                {
                    productList = _productService.MapProduct(listProducts, storeId);
                    if (productList.Count < 1)
                    {
                        return NotFound();
                    }
                    else { result = productList.FirstOrDefault(p => p.ProductId == productId); }
                }
                catch (Exception e)
                {
                    return NotFound(e.Message);
                }
                return Ok(result);
            }
            return BadRequest("Invalid Token!");
        }


    }
}