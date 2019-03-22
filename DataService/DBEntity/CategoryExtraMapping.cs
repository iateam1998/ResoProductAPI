using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CategoryExtraMapping
    {
        public int Id { get; set; }
        public int PrimaryCategoryId { get; set; }
        public int ExtraCategoryId { get; set; }
        public bool IsEnable { get; set; }

        public virtual ProductCategory ExtraCategory { get; set; }
        public virtual ProductCategory PrimaryCategory { get; set; }
    }
}
