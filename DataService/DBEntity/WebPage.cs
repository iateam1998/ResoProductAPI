using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class WebPage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PageContent { get; set; }
        public string PageTitle { get; set; }
        public string MetaDescription { get; set; }
        public bool IsActive { get; set; }
        public int? StoreId { get; set; }
        public string SeoName { get; set; }
        public string MetaKeyword { get; set; }

        public virtual Store Store { get; set; }
    }
}
