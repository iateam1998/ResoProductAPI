using ProductAPIClient.APIs;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ProductAPIClient
{
    public class ProductClient
    {
        public HttpClient _client { get; set; }
        public ProductClientInfo _info { get; set; }

        public ProductAPI _productAPI { get; set; }
        public ProductCategoryAPI _productCategoryAPI { get; set; }

        public ProductClient(ProductClientInfo productClientInfo)
        {
            _info = productClientInfo;
            _client = new HttpClient();
            _client.BaseAddress = new Uri(productClientInfo.BaseAddress);

            _productAPI = new ProductAPI(this);
            _productCategoryAPI = new ProductCategoryAPI(this);
        }
        public void Dispose()
        {
            _client.Dispose();
        }
    }
    public class ProductClientInfo
    {
        private string baseAddress;
        public string BaseAddress
        {
            get
            {
                return baseAddress;
            }
            set
            {
                baseAddress = value;
                if (baseAddress.EndsWith("/") || baseAddress.EndsWith("\\"))
                    baseAddress.Remove(baseAddress.Length - 1);
            }
        }
    }
}
