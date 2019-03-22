using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class VatorderMapping
    {
        public int Id { get; set; }
        public int RentId { get; set; }
        public int InvoiceId { get; set; }

        public virtual Vatorder Invoice { get; set; }
    }
}
