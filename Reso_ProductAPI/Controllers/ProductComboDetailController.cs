using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService;
using DataService.ServiceAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Reso_ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductComboDetailController : ControllerBase
    {
        IUtils _utils;
        private readonly IServiceProvider _serviceProvider;
        public ProductComboDetailController(IUtils utils, IServiceProvider serviceProvider)
        {
            _utils = utils;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Get All Combos Of Store 
        /// </summary>
        /// <param name="storeId"> Store Id (Required)</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{storeId}")]
        public IActionResult GetListComboByStoreId(int storeId)
        {
            var _productComboService = ServiceFactory.CreateService<IProductComboDetailService>(_serviceProvider);
            var result = _productComboService.GetProductComboAPIViews(storeId);
            if (result == null /*|| result.Count<ICollection<ProductImageViewModel>>() < 1*/)
            {
                return NotFound();
            }
            return Ok(result);
        }

        /// <summary>
        /// Get Combo Of Store 
        /// </summary>
        /// <param name="storeId"> Store Id (Required)</param>
        /// <param name="comboId"> Combo Id (Required)</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{storeId}/{comboId}")]
        public IActionResult GetComboByComboId(int storeId, int comboId)
        {
            var _productComboService = ServiceFactory.CreateService<IProductComboDetailService>(_serviceProvider);
            var result = _productComboService.GetProductComboByProductId(storeId, comboId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}