using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductItemCompositionMappingViewModel : BaseViewModel<ProductItemCompositionMapping>
    {
        public ProductItemViewModel ProductItem { get; set; }
    }
}
