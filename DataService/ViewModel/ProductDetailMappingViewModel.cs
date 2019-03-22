using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductDetailMappingViewModel : BaseViewModel<ProductDetailMapping>
    {
        public int ProductDetailId { get; set; }
        public int? ProductId { get; set; }
        public int? StoreId { get; set; }
        public double? Price { get; set; }
        public double? DiscountPrice { get; set; }
        public double? DiscountPercent { get; set; }
        public bool? Active { get; set; }
        public int? SaleMethodEnum { get; set; }

        public virtual ProductViewModel Product { get; set; }
        public virtual StoreViewModel Store { get; set; }
    }
}
