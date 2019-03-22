using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ProductItem
    {
        public ProductItem()
        {
            InventoryDateReportItem = new HashSet<InventoryDateReportItem>();
            InventoryReceiptItem = new HashSet<InventoryReceiptItem>();
            ProductItemCompositionMapping = new HashSet<ProductItemCompositionMapping>();
            ProviderProductItemMapping = new HashSet<ProviderProductItemMapping>();
            TemplateReportProductItemMapping = new HashSet<TemplateReportProductItemMapping>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public bool? IsAvailable { get; set; }
        public string ImageUrl { get; set; }
        public int? CatId { get; set; }
        public double? Price { get; set; }
        public string Unit2 { get; set; }
        public double? UnitRate { get; set; }
        public int? IndexPriority { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ItemType { get; set; }
        public string ItemCode { get; set; }

        public virtual ProductItemCategory Cat { get; set; }
        public virtual ICollection<InventoryDateReportItem> InventoryDateReportItem { get; set; }
        public virtual ICollection<InventoryReceiptItem> InventoryReceiptItem { get; set; }
        public virtual ICollection<ProductItemCompositionMapping> ProductItemCompositionMapping { get; set; }
        public virtual ICollection<ProviderProductItemMapping> ProviderProductItemMapping { get; set; }
        public virtual ICollection<TemplateReportProductItemMapping> TemplateReportProductItemMapping { get; set; }
    }
}
