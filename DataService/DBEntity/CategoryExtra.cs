using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CategoryExtra
    {
        public int CategoryExtraId { get; set; }
        public int PrimaryCategoryId { get; set; }
        public int ExtraCategoryId { get; set; }
        public bool IsEnable { get; set; }
    }
}
