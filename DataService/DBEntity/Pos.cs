using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Pos
    {
        public int PosId { get; set; }
        public string MacId { get; set; }
        public string PosConfig { get; set; }
        public string PosCode { get; set; }
    }
}
