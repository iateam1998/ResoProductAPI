using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductItemViewModel : BaseViewModel<ProductItem>
    {
        public ProductItemCategoryViewModel ItemCategory { get; set; }
        public string CateName { get; set; }
        public double? Quantity { get; set; }
    }
}
