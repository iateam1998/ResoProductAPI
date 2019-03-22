using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string CustomerType1 { get; set; }
        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
