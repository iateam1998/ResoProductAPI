using ProductAPIClient.RequestModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPIClient.APIs
{
    public class ProductCategoryAPI
    {
        public string RoutePrefix { get; set; } = "api/ProductCategory";
        protected ProductClient _productClient { get; set; }
        public ProductCategoryAPI(ProductClient client)
        {
            _productClient = client;
        }

        public async Task<HttpResponseMessage> Get(ProductRequestModel req)
        {
            var route = "";
            var uri = RoutePrefix + "/" + route;
            if (req != null)
            {
                uri += req.token + "/" + req.storeId;
            }
            return await _productClient._client.GetAsync(uri);
        }
    }
}
