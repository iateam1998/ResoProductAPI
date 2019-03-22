using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Customer
    {
        public Customer()
        {
            Account = new HashSet<Account>();
            AspNetUsers = new HashSet<AspNetUsers>();
            CustomerDevice = new HashSet<CustomerDevice>();
            CustomerProductMapping = new HashSet<CustomerProductMapping>();
            CustomerStoreReportMapping = new HashSet<CustomerStoreReportMapping>();
            DeliveryInfo = new HashSet<DeliveryInfo>();
            DeliveryInformation = new HashSet<DeliveryInformation>();
            InverseParent = new HashSet<Customer>();
            Membership = new HashSet<Membership>();
            Order = new HashSet<Order>();
            OrderGroup = new HashSet<OrderGroup>();
            Rating = new HashSet<Rating>();
            Receipt = new HashSet<Receipt>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonNumber { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public int Type { get; set; }
        public int? AccountId { get; set; }
        public string Idcard { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? StoreRegisterId { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string CustomerCode { get; set; }
        public int? CustomerTypeId { get; set; }
        public int? BrandId { get; set; }
        public int? DeliveryInfoDefault { get; set; }
        public string PicUrl { get; set; }
        public string AccountPhone { get; set; }
        public string FacebookId { get; set; }
        public int? PartnerId { get; set; }
        public int? ParentId { get; set; }

        public virtual CustomerType CustomerType { get; set; }
        public virtual Customer Parent { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<CustomerDevice> CustomerDevice { get; set; }
        public virtual ICollection<CustomerProductMapping> CustomerProductMapping { get; set; }
        public virtual ICollection<CustomerStoreReportMapping> CustomerStoreReportMapping { get; set; }
        public virtual ICollection<DeliveryInfo> DeliveryInfo { get; set; }
        public virtual ICollection<DeliveryInformation> DeliveryInformation { get; set; }
        public virtual ICollection<Customer> InverseParent { get; set; }
        public virtual ICollection<Membership> Membership { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<OrderGroup> OrderGroup { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}
