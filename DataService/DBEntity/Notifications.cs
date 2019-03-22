using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string PicUrl { get; set; }
        public string Opening { get; set; }
        public string Content { get; set; }
        public bool? Active { get; set; }
        public int? CustomerId { get; set; }
    }
}
