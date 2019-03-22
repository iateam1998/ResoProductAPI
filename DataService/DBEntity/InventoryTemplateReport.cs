using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class InventoryTemplateReport
    {
        public InventoryTemplateReport()
        {
            TemplateReportProductItemMapping = new HashSet<TemplateReportProductItemMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<TemplateReportProductItemMapping> TemplateReportProductItemMapping { get; set; }
    }
}
