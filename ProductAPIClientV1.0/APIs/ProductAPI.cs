using ProductAPIClient.RequestModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPIClient.APIs
{
    public class ProductAPI
    {
        public string RoutePrefix { get; set; } = "api/Product";
        protected ProductClient _productClient { get; set; }
        public ProductAPI(ProductClient client)
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
                if (req.categoryId != null)
                {
                    uri += "?categoryId=" + req.categoryId;
                }
            }
            return await _productClient._client.GetAsync(uri);
        }

    }
}
