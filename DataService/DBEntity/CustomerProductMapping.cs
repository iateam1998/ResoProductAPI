using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CustomerProductMapping
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int TotalQuantity { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
