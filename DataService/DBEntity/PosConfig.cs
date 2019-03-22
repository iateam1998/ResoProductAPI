using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PosConfig
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int PosFileId { get; set; }

        public virtual PosFile PosFile { get; set; }
    }
}
