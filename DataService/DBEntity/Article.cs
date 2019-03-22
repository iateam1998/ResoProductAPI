using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Article
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public string ContentHtml { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsAvailable { get; set; }
        public string Thumbnail { get; set; }

        public virtual Store Store { get; set; }
    }
}
