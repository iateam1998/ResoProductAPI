using ProductAPIClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAPIClient.RequestModels;

namespace ProductAPIClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductClient client = new ProductClient(new ProductClientInfo()
            {
                BaseAddress = "http://localhost:58411/"
            }
            );
            var result = client._productCategoryAPI.Get(new ProductRequestModel()
            {
                storeId = 1087,
                token = "494EC308-7344-41A9-9347-D05754002CFC"
            }
            ).Result;
            string json = result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(json);
        }
    }
}
