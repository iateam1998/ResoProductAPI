using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class ImageCollectionItem
    {
        public int Id { get; set; }
        public int ImageCollectionId { get; set; }
        public string Title { get; set; }
        public string TitleEng { get; set; }
        public string ImageUrl { get; set; }
        public bool Active { get; set; }
        public int Position { get; set; }
        public string Description { get; set; }
        public string DescriptionEng { get; set; }
        public string Link { get; set; }

        public virtual ImageCollection ImageCollection { get; set; }
    }
}
