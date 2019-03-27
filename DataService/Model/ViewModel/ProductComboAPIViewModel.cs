using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ViewModel
{
    public class ProductComboAPIViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductNameEng { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string PicUrl { get; set; }
        public int CatId { get; set; }
        public bool IsAvailable { get; set; }
        public string Code { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountPrice { get; set; }
        public int ProductType { get; set; }
        public List<ProductViewModel> listProducts { get; set; }
    }
}
