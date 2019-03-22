using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Order
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
            OrderFeeItem = new HashSet<OrderFeeItem>();
            OrderPromotionMapping = new HashSet<OrderPromotionMapping>();
            Payment = new HashSet<Payment>();
            Rating = new HashSet<Rating>();
            Receipt = new HashSet<Receipt>();
        }

        public int RentId { get; set; }
        public string InvoiceId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? ApproveDate { get; set; }
        public double TotalAmount { get; set; }
        public double Discount { get; set; }
        public double DiscountOrderDetail { get; set; }
        public double FinalAmount { get; set; }
        public int OrderStatus { get; set; }
        public int? RentStatus { get; set; }
        public int OrderType { get; set; }
        public int RentType { get; set; }
        public string Notes { get; set; }
        public string FeeDescription { get; set; }
        public string CheckInPerson { get; set; }
        public string CheckOutPerson { get; set; }
        public string ApprovePerson { get; set; }
        public int? PriceGroupId { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? CustomerId { get; set; }
        public int? CustomerTypeId { get; set; }
        public int? SubRentGroupId { get; set; }
        public int? RoomId { get; set; }
        public bool IsFixedPrice { get; set; }
        public DateTime? LastRecordDate { get; set; }
        public string ServedPerson { get; set; }
        public int? StoreId { get; set; }
        public int? SourceId { get; set; }
        public int SourceType { get; set; }
        public string DeliveryAddress { get; set; }
        public int? DeliveryStatus { get; set; }
        public int? OrderDetailsTotalQuantity { get; set; }
        public int? CheckinHour { get; set; }
        public int? TotalInvoicePrint { get; set; }
        public double? Vat { get; set; }
        public double? Vatamount { get; set; }
        public int? NumberOfGuest { get; set; }
        public string Att1 { get; set; }
        public string Att2 { get; set; }
        public string Att3 { get; set; }
        public string Att4 { get; set; }
        public string Att5 { get; set; }
        public int GroupPaymentStatus { get; set; }
        public string DeliveryReceiver { get; set; }
        public string DeliveryPhone { get; set; }
        public DateTime? LastModifiedPayment { get; set; }
        public DateTime? LastModifiedOrderDetail { get; set; }
        public int? PaymentStatus { get; set; }
        public int? DeliveryType { get; set; }
        public int? DeliveryPayment { get; set; }
        public int? InvoiceStatus { get; set; }
        public int? WardCode { get; set; }
        public int? DistrictCode { get; set; }
        public int? ProvinceCode { get; set; }
        public int? PromotionPartnerId { get; set; }
        public double? MemberPoint { get; set; }
        public string Receiver { get; set; }
        public bool IsExported { get; set; }
        public string TableCode { get; set; }
        public bool? IsSync { get; set; }
        public int? PersonCount { get; set; }
        public bool? Active { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual District DistrictCodeNavigation { get; set; }
        public virtual PriceGroup PriceGroup { get; set; }
        public virtual PromotionPartner PromotionPartner { get; set; }
        public virtual Province ProvinceCodeNavigation { get; set; }
        public virtual Room Room { get; set; }
        public virtual Store Store { get; set; }
        public virtual SubRentGroup SubRentGroup { get; set; }
        public virtual Ward WardCodeNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<OrderFeeItem> OrderFeeItem { get; set; }
        public virtual ICollection<OrderPromotionMapping> OrderPromotionMapping { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}
