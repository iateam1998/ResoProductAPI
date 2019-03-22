using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Receipt
    {
        public Receipt()
        {
            FinanceTransaction = new HashSet<FinanceTransaction>();
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string ReceiptCode { get; set; }
        public double FinalAmount { get; set; }
        public string ReceiptDescription { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? ReceiptStatus { get; set; }
        public int ReceiptType { get; set; }
        public int ReceiptPaymentType { get; set; }
        public string ApprovedPersonId { get; set; }
        public string ApprovedPersonName { get; set; }
        public int? CustomerId { get; set; }
        public int? OrderId { get; set; }

        public virtual AspNetUsers ApprovedPerson { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<FinanceTransaction> FinanceTransaction { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
