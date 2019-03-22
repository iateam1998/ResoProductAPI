using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class FingerScanMachine
    {
        public FingerScanMachine()
        {
            CheckFinger = new HashSet<CheckFinger>();
        }

        public int Id { get; set; }
        public string MachineCode { get; set; }
        public string Name { get; set; }
        public int StoreId { get; set; }
        public string Url { get; set; }
        public string Ip { get; set; }
        public string BrandOfMachine { get; set; }
        public DateTime? DateOfManufacture { get; set; }
        public bool Active { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<CheckFinger> CheckFinger { get; set; }
    }
}
