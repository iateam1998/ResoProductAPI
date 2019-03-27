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
    public class ProductImageController : ControllerBase
    {
        IUtils _utils;
        private readonly IServiceProvider _serviceProvider;
        public ProductImageController(IUtils utils, IServiceProvider serviceProvider)
        {
            _utils = utils;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Get All Product Image of Store
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{storeId}")]
        public IActionResult GetListImagesByStoreId(int storeId)
        {
            var _productImageService = ServiceFactory.CreateService<IProductImageService>(_serviceProvider);
            var result = _productImageService.GetListImagesByStoreId(storeId);
            if(result == null /*|| result.Count<ICollection<ProductImageViewModel>>() < 1*/)
            {
                return NotFound();
            }
            return Ok(result);
        }

        /// <summary>
        /// Get Product Image of Store
        /// </summary>
        /// <param name="storeId">Store Id (Required)</param>
        /// <param name="productId">Product Id (Required)</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{storeId}/{productId}")]
        public IActionResult GetImageByProductId(int storeId, int productId)
        {
            var _productImageService = ServiceFactory.CreateService<IProductImageService>(_serviceProvider);
            var result = _productImageService.GetImageByProductId(storeId, productId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}