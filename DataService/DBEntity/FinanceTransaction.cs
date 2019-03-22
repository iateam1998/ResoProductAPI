using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class FinanceTransaction
    {
        public int Id { get; set; }
        public string FtransCode { get; set; }
        public double Damount { get; set; }
        public double Camount { get; set; }
        public string Fdescription { get; set; }
        public int ReceiptId { get; set; }
        public int FtransStatus { get; set; }
        public int FtransType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
