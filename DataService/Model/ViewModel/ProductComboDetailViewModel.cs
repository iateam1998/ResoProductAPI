using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductComboDetailViewModel : BaseViewModel<ProductComboDetail>
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }
        public int ComboId { get; set; }

        public virtual ProductViewModel Combo { get; set; }
        public virtual ProductViewModel Product { get; set; }
    }
}
