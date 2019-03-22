using DataService.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductComboDetailViewModel : BaseViewModel<ProductComboDetail>
    {
        public virtual int ProductID { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int Position { get; set; }
        public virtual bool Active { get; set; }
        public virtual int ComboID { get; set; }
    }
}
