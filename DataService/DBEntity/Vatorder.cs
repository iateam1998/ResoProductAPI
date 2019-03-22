using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Vatorder
    {
        public Vatorder()
        {
            VatorderMapping = new HashSet<VatorderMapping>();
        }

        public int InvoiceId { get; set; }
        public int BrandId { get; set; }
        public string VatorderDetail { get; set; }
        public int Type { get; set; }
        public string InvoiceNo { get; set; }
        public string CheckInPerson { get; set; }
        public DateTime CheckInDate { get; set; }
        public string Notes { get; set; }
        public double Total { get; set; }
        public double Vatamount { get; set; }
        public int ProviderId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ICollection<VatorderMapping> VatorderMapping { get; set; }
    }
}
