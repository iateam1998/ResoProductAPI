using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PosFile
    {
        public PosFile()
        {
            PosConfig = new HashSet<PosConfig>();
        }

        public int Id { get; set; }
        public string FileName { get; set; }
        public int? StoreId { get; set; }
        public int BrandId { get; set; }
        public string Version { get; set; }

        public virtual ICollection<PosConfig> PosConfig { get; set; }
    }
}
