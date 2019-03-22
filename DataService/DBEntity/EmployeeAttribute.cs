using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class EmployeeAttribute
    {
        public EmployeeAttribute()
        {
            EmployeeAttributeMapping = new HashSet<EmployeeAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int BrandId { get; set; }

        public virtual ICollection<EmployeeAttributeMapping> EmployeeAttributeMapping { get; set; }
    }
}
