using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductComboDetail
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }
        public int ComboId { get; set; }

        public virtual Product Combo { get; set; }
        public virtual Product Product { get; set; }
    }
}
