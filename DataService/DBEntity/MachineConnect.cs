using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class MachineConnect
    {
        public int Id { get; set; }
        public int MachineId { get; set; }
        public DateTime? ConnectTime { get; set; }
        public bool? ConnectResult { get; set; }
        public int StoreId { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }
        public string MachineName { get; set; }
        public string MachineCode { get; set; }
    }
}
