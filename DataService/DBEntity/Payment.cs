using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? ToRentId { get; set; }
        public double Amount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Fcamount { get; set; }
        public string Notes { get; set; }
        public DateTime PayTime { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public double? RealAmount { get; set; }
        public string CardCode { get; set; }
        public int? CostId { get; set; }
        public int? AccountId { get; set; }
        public int? CardId { get; set; }
        public int? PersonCount { get; set; }
        public int? ReceiptId { get; set; }
        public string PaymentCode { get; set; }
        public string TransactionCodeRef { get; set; }
        public bool? Active { get; set; }

        public virtual Account Account { get; set; }
        public virtual Card Card { get; set; }
        public virtual Cost Cost { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual Order ToRent { get; set; }
    }
}
