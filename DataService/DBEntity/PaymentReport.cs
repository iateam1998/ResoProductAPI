using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class PaymentReport
    {
        public int Id { get; set; }
        public string CreateBy { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
        public int StoreId { get; set; }
        public double CashAmount { get; set; }
        public double MemberCardAmount { get; set; }
        public double BankAmount { get; set; }
        public double VoucherAmount { get; set; }
        public double DebtAmount { get; set; }
        public double OtherAmount { get; set; }
        public double PayDebtAmount { get; set; }
        public double ReceiptAmount { get; set; }
        public double SpendAmount { get; set; }

        public virtual Store Store { get; set; }
    }
}
