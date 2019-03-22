using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Store
    {
        public Store()
        {
            Article = new HashSet<Article>();
            AspNetUsers = new HashSet<AspNetUsers>();
            Attendance = new HashSet<Attendance>();
            AttendanceDate = new HashSet<AttendanceDate>();
            BlogCategory = new HashSet<BlogCategory>();
            BlogPost = new HashSet<BlogPost>();
            BlogPostCollection = new HashSet<BlogPostCollection>();
            Cost = new HashSet<Cost>();
            Coupon = new HashSet<Coupon>();
            CustomerStoreReportMapping = new HashSet<CustomerStoreReportMapping>();
            DateProduct = new HashSet<DateProduct>();
            DateProductItem = new HashSet<DateProductItem>();
            DateReport = new HashSet<DateReport>();
            Device = new HashSet<Device>();
            EmployeeInStore = new HashSet<EmployeeInStore>();
            FingerScanMachine = new HashSet<FingerScanMachine>();
            ImageCollection = new HashSet<ImageCollection>();
            InventoryDateReport = new HashSet<InventoryDateReport>();
            InventoryReceiptInStore = new HashSet<InventoryReceipt>();
            InventoryReceiptOutStore = new HashSet<InventoryReceipt>();
            InventoryReceiptStore = new HashSet<InventoryReceipt>();
            Language = new HashSet<Language>();
            LanguageKey = new HashSet<LanguageKey>();
            Order = new HashSet<Order>();
            PaymentReport = new HashSet<PaymentReport>();
            ProductCollection = new HashSet<ProductCollection>();
            ProductDetailMapping = new HashSet<ProductDetailMapping>();
            PromotionStoreMapping = new HashSet<PromotionStoreMapping>();
            Rating = new HashSet<Rating>();
            ReportTracking = new HashSet<ReportTracking>();
            RoomCategory = new HashSet<RoomCategory>();
            StoreDomain = new HashSet<StoreDomain>();
            StoreGroupMapping = new HashSet<StoreGroupMapping>();
            StoreTheme = new HashSet<StoreTheme>();
            StoreUser = new HashSet<StoreUser>();
            StoreWebRoute = new HashSet<StoreWebRoute>();
            StoreWebSetting = new HashSet<StoreWebSetting>();
            StoreWebViewCounter = new HashSet<StoreWebViewCounter>();
            ViewCounter = new HashSet<ViewCounter>();
            WebMenuCategory = new HashSet<WebMenuCategory>();
            WebPage = new HashSet<WebPage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public bool? IsAvailable { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public DateTime? CreateDate { get; set; }
        public int Type { get; set; }
        public int? RoomRentMode { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ShortName { get; set; }
        public int? GroupId { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public string DefaultAdminPassword { get; set; }
        public bool? HasProducts { get; set; }
        public bool? HasNews { get; set; }
        public bool? HasImageCollections { get; set; }
        public bool? HasMultipleLanguage { get; set; }
        public bool? HasWebPages { get; set; }
        public bool? HasCustomerFeedbacks { get; set; }
        public int? BrandId { get; set; }
        public bool? HasOrder { get; set; }
        public bool? HasBlogEditCollections { get; set; }
        public string LogoUrl { get; set; }
        public string FbAccessToken { get; set; }
        public string StoreFeatureFilter { get; set; }
        public bool? RunReport { get; set; }
        public int? AttendanceStoreFilter { get; set; }
        public string StoreCode { get; set; }
        public int? PosId { get; set; }
        public string StoreConfig { get; set; }
        public string DefaultDashBoard { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public bool? Active { get; set; }
        public int? PaymentTypeApply { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Article> Article { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<AttendanceDate> AttendanceDate { get; set; }
        public virtual ICollection<BlogCategory> BlogCategory { get; set; }
        public virtual ICollection<BlogPost> BlogPost { get; set; }
        public virtual ICollection<BlogPostCollection> BlogPostCollection { get; set; }
        public virtual ICollection<Cost> Cost { get; set; }
        public virtual ICollection<Coupon> Coupon { get; set; }
        public virtual ICollection<CustomerStoreReportMapping> CustomerStoreReportMapping { get; set; }
        public virtual ICollection<DateProduct> DateProduct { get; set; }
        public virtual ICollection<DateProductItem> DateProductItem { get; set; }
        public virtual ICollection<DateReport> DateReport { get; set; }
        public virtual ICollection<Device> Device { get; set; }
        public virtual ICollection<EmployeeInStore> EmployeeInStore { get; set; }
        public virtual ICollection<FingerScanMachine> FingerScanMachine { get; set; }
        public virtual ICollection<ImageCollection> ImageCollection { get; set; }
        public virtual ICollection<InventoryDateReport> InventoryDateReport { get; set; }
        public virtual ICollection<InventoryReceipt> InventoryReceiptInStore { get; set; }
        public virtual ICollection<InventoryReceipt> InventoryReceiptOutStore { get; set; }
        public virtual ICollection<InventoryReceipt> InventoryReceiptStore { get; set; }
        public virtual ICollection<Language> Language { get; set; }
        public virtual ICollection<LanguageKey> LanguageKey { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<PaymentReport> PaymentReport { get; set; }
        public virtual ICollection<ProductCollection> ProductCollection { get; set; }
        public virtual ICollection<ProductDetailMapping> ProductDetailMapping { get; set; }
        public virtual ICollection<PromotionStoreMapping> PromotionStoreMapping { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<ReportTracking> ReportTracking { get; set; }
        public virtual ICollection<RoomCategory> RoomCategory { get; set; }
        public virtual ICollection<StoreDomain> StoreDomain { get; set; }
        public virtual ICollection<StoreGroupMapping> StoreGroupMapping { get; set; }
        public virtual ICollection<StoreTheme> StoreTheme { get; set; }
        public virtual ICollection<StoreUser> StoreUser { get; set; }
        public virtual ICollection<StoreWebRoute> StoreWebRoute { get; set; }
        public virtual ICollection<StoreWebSetting> StoreWebSetting { get; set; }
        public virtual ICollection<StoreWebViewCounter> StoreWebViewCounter { get; set; }
        public virtual ICollection<ViewCounter> ViewCounter { get; set; }
        public virtual ICollection<WebMenuCategory> WebMenuCategory { get; set; }
        public virtual ICollection<WebPage> WebPage { get; set; }
    }
}
