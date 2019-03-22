using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Fcamount { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public bool IsIncreaseTransaction { get; set; }
        public int Status { get; set; }
        public int StoreId { get; set; }
        public int BrandId { get; set; }
        public string UserId { get; set; }
        public int TransactionType { get; set; }
        public string PaymentCodeRef { get; set; }
        public string TransactionCode { get; set; }

        public virtual Account Account { get; set; }
    }
}
