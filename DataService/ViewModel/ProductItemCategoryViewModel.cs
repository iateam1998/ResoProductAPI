using DataService.DBEntity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductItemCategoryViewModel : BaseViewModel<ProductItemCategory>
    {
        public IEnumerable<SelectList> AvailbleProductCategories { get; set; }
    }
}
