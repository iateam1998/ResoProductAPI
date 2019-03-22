using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Brand
    {
        public Brand()
        {
            Card = new HashSet<Card>();
            Contact = new HashSet<Contact>();
            CustomerFilter = new HashSet<CustomerFilter>();
            CustomerType = new HashSet<CustomerType>();
            InventoryTemplateReport = new HashSet<InventoryTemplateReport>();
            Membership = new HashSet<Membership>();
            MembershipType = new HashSet<MembershipType>();
            PartnerMapping = new HashSet<PartnerMapping>();
            ProductCategory = new HashSet<ProductCategory>();
            ProductCollection = new HashSet<ProductCollection>();
            Store = new HashSet<Store>();
            StoreGroup = new HashSet<StoreGroup>();
            Vatorder = new HashSet<Vatorder>();
        }

        public int Id { get; set; }
        public string BrandName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Vatcode { get; set; }
        public int? Vattemplate { get; set; }
        public string Address { get; set; }
        public string ApiSmskey { get; set; }
        public string SecurityApiSmskey { get; set; }
        public int? Smstype { get; set; }
        public string BrandNameSms { get; set; }
        public string JsonConfigUrl { get; set; }
        public string BrandFeatureFilter { get; set; }
        public int? WiskyId { get; set; }
        public string DefaultDashBoard { get; set; }
        public string RsaprivateKey { get; set; }
        public string RsapublicKey { get; set; }
        public string Pgppassword { get; set; }
        public string PgpprivateKey { get; set; }
        public string PgppulblicKey { get; set; }
        public string DesKey { get; set; }
        public string DesVector { get; set; }
        public string AccessToken { get; set; }
        public string TaxCode { get; set; }
        public string DefaultDomain { get; set; }
        public string DefaultImage { get; set; }

        public virtual ICollection<Card> Card { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<CustomerFilter> CustomerFilter { get; set; }
        public virtual ICollection<CustomerType> CustomerType { get; set; }
        public virtual ICollection<InventoryTemplateReport> InventoryTemplateReport { get; set; }
        public virtual ICollection<Membership> Membership { get; set; }
        public virtual ICollection<MembershipType> MembershipType { get; set; }
        public virtual ICollection<PartnerMapping> PartnerMapping { get; set; }
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
        public virtual ICollection<ProductCollection> ProductCollection { get; set; }
        public virtual ICollection<Store> Store { get; set; }
        public virtual ICollection<StoreGroup> StoreGroup { get; set; }
        public virtual ICollection<Vatorder> Vatorder { get; set; }
    }
}
