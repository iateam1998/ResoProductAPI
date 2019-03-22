using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPIClient.RequestModels
{
    public class ProductRequestModel
    {
        public string token { get; set; }
        public int storeId { get; set; }
        public int? categoryId { get; set; }

    }
}
