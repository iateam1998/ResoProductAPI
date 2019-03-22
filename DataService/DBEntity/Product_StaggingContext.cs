using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataService.DBEntity
{
    public partial class Product_StaggingContext : DbContext
    {
        public Product_StaggingContext()
        {
        }

        public Product_StaggingContext(DbContextOptions<Product_StaggingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<AreaDelivery> AreaDelivery { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<AttendanceDate> AttendanceDate { get; set; }
        public virtual DbSet<BlogCategory> BlogCategory { get; set; }
        public virtual DbSet<BlogPost> BlogPost { get; set; }
        public virtual DbSet<BlogPostCollection> BlogPostCollection { get; set; }
        public virtual DbSet<BlogPostCollectionItem> BlogPostCollectionItem { get; set; }
        public virtual DbSet<BlogPostCollectionItemMapping> BlogPostCollectionItemMapping { get; set; }
        public virtual DbSet<BlogPostImage> BlogPostImage { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<CategoryExtra> CategoryExtra { get; set; }
        public virtual DbSet<CategoryExtraMapping> CategoryExtraMapping { get; set; }
        public virtual DbSet<CheckFinger> CheckFinger { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Cost> Cost { get; set; }
        public virtual DbSet<CostCategory> CostCategory { get; set; }
        public virtual DbSet<CostInventoryMapping> CostInventoryMapping { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<CouponCampaign> CouponCampaign { get; set; }
        public virtual DbSet<CouponProvider> CouponProvider { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerDevice> CustomerDevice { get; set; }
        public virtual DbSet<CustomerFilter> CustomerFilter { get; set; }
        public virtual DbSet<CustomerProductMapping> CustomerProductMapping { get; set; }
        public virtual DbSet<CustomerStoreReportMapping> CustomerStoreReportMapping { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<DateHotelReport> DateHotelReport { get; set; }
        public virtual DbSet<DateProduct> DateProduct { get; set; }
        public virtual DbSet<DateProductItem> DateProductItem { get; set; }
        public virtual DbSet<DateReport> DateReport { get; set; }
        public virtual DbSet<DayMode> DayMode { get; set; }
        public virtual DbSet<DeliveryInfo> DeliveryInfo { get; set; }
        public virtual DbSet<DeliveryInformation> DeliveryInformation { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeAttribute> EmployeeAttribute { get; set; }
        public virtual DbSet<EmployeeAttributeMapping> EmployeeAttributeMapping { get; set; }
        public virtual DbSet<EmployeeFingers> EmployeeFingers { get; set; }
        public virtual DbSet<EmployeeGroup> EmployeeGroup { get; set; }
        public virtual DbSet<EmployeeInStore> EmployeeInStore { get; set; }
        public virtual DbSet<EventLocation> EventLocation { get; set; }
        public virtual DbSet<Favorited> Favorited { get; set; }
        public virtual DbSet<FinanceTransaction> FinanceTransaction { get; set; }
        public virtual DbSet<FingerScanMachine> FingerScanMachine { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Guest> Guest { get; set; }
        public virtual DbSet<ImageCollection> ImageCollection { get; set; }
        public virtual DbSet<ImageCollectionItem> ImageCollectionItem { get; set; }
        public virtual DbSet<InventoryChecking> InventoryChecking { get; set; }
        public virtual DbSet<InventoryCheckingItem> InventoryCheckingItem { get; set; }
        public virtual DbSet<InventoryDateReport> InventoryDateReport { get; set; }
        public virtual DbSet<InventoryDateReportItem> InventoryDateReportItem { get; set; }
        public virtual DbSet<InventoryReceipt> InventoryReceipt { get; set; }
        public virtual DbSet<InventoryReceiptItem> InventoryReceiptItem { get; set; }
        public virtual DbSet<InventoryTemplateReport> InventoryTemplateReport { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LanguageKey> LanguageKey { get; set; }
        public virtual DbSet<LanguageValue> LanguageValue { get; set; }
        public virtual DbSet<MachineConnect> MachineConnect { get; set; }
        public virtual DbSet<Membership> Membership { get; set; }
        public virtual DbSet<MembershipType> MembershipType { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuRole> MenuRole { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderDetailPromotionMapping> OrderDetailPromotionMapping { get; set; }
        public virtual DbSet<OrderFeeItem> OrderFeeItem { get; set; }
        public virtual DbSet<OrderGroup> OrderGroup { get; set; }
        public virtual DbSet<OrderPromotionMapping> OrderPromotionMapping { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PartnerMapping> PartnerMapping { get; set; }
        public virtual DbSet<PaySlip> PaySlip { get; set; }
        public virtual DbSet<PaySlipItem> PaySlipItem { get; set; }
        public virtual DbSet<PaySlipTemplate> PaySlipTemplate { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentPartner> PaymentPartner { get; set; }
        public virtual DbSet<PaymentReport> PaymentReport { get; set; }
        public virtual DbSet<PayrollCategory> PayrollCategory { get; set; }
        public virtual DbSet<PayrollDetail> PayrollDetail { get; set; }
        public virtual DbSet<PayrollPeriod> PayrollPeriod { get; set; }
        public virtual DbSet<PayslipAttribute> PayslipAttribute { get; set; }
        public virtual DbSet<PayslipAttributeMapping> PayslipAttributeMapping { get; set; }
        public virtual DbSet<Pos> Pos { get; set; }
        public virtual DbSet<PosConfig> PosConfig { get; set; }
        public virtual DbSet<PosFile> PosFile { get; set; }
        public virtual DbSet<PriceAddition> PriceAddition { get; set; }
        public virtual DbSet<PriceGroup> PriceGroup { get; set; }
        public virtual DbSet<PriceNight> PriceNight { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductBrand> ProductBrand { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCollection> ProductCollection { get; set; }
        public virtual DbSet<ProductCollectionItemMapping> ProductCollectionItemMapping { get; set; }
        public virtual DbSet<ProductComboDetail> ProductComboDetail { get; set; }
        public virtual DbSet<ProductDetailMapping> ProductDetailMapping { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductImageCollection> ProductImageCollection { get; set; }
        public virtual DbSet<ProductImageCollectionItemMapping> ProductImageCollectionItemMapping { get; set; }
        public virtual DbSet<ProductItem> ProductItem { get; set; }
        public virtual DbSet<ProductItemCategory> ProductItemCategory { get; set; }
        public virtual DbSet<ProductItemCompositionMapping> ProductItemCompositionMapping { get; set; }
        public virtual DbSet<ProductSpecification> ProductSpecification { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<PromotionDetail> PromotionDetail { get; set; }
        public virtual DbSet<PromotionPartner> PromotionPartner { get; set; }
        public virtual DbSet<PromotionStoreMapping> PromotionStoreMapping { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderProductItemMapping> ProviderProductItemMapping { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<RatingStar> RatingStar { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<ReportTracking> ReportTracking { get; set; }
        public virtual DbSet<RequestHistory> RequestHistory { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<RoomCategory> RoomCategory { get; set; }
        public virtual DbSet<RoomCategoryPriceGroupMapping> RoomCategoryPriceGroupMapping { get; set; }
        public virtual DbSet<RoomFloor> RoomFloor { get; set; }
        public virtual DbSet<SalaryHour> SalaryHour { get; set; }
        public virtual DbSet<SalaryRule> SalaryRule { get; set; }
        public virtual DbSet<ShiftRegister> ShiftRegister { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreDomain> StoreDomain { get; set; }
        public virtual DbSet<StoreGroup> StoreGroup { get; set; }
        public virtual DbSet<StoreGroupMapping> StoreGroupMapping { get; set; }
        public virtual DbSet<StoreTheme> StoreTheme { get; set; }
        public virtual DbSet<StoreUser> StoreUser { get; set; }
        public virtual DbSet<StoreWebRoute> StoreWebRoute { get; set; }
        public virtual DbSet<StoreWebRouteModel> StoreWebRouteModel { get; set; }
        public virtual DbSet<StoreWebSetting> StoreWebSetting { get; set; }
        public virtual DbSet<StoreWebViewCounter> StoreWebViewCounter { get; set; }
        public virtual DbSet<SubRentGroup> SubRentGroup { get; set; }
        public virtual DbSet<SystemPartnerMapping> SystemPartnerMapping { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TagMapping> TagMapping { get; set; }
        public virtual DbSet<TaskDetail> TaskDetail { get; set; }
        public virtual DbSet<TemplateDetailMapping> TemplateDetailMapping { get; set; }
        public virtual DbSet<TemplateReportProductItemMapping> TemplateReportProductItemMapping { get; set; }
        public virtual DbSet<TemplateRuleMapping> TemplateRuleMapping { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<TimeFrame> TimeFrame { get; set; }
        public virtual DbSet<TimeModeRule> TimeModeRule { get; set; }
        public virtual DbSet<TimeModeType> TimeModeType { get; set; }
        public virtual DbSet<TokenUser> TokenUser { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TransactionIndex2244ceaa24f54fdeBd5fBaf8ea08cdc4> TransactionIndex2244ceaa24f54fdeBd5fBaf8ea08cdc4 { get; set; }
        public virtual DbSet<UserAccess> UserAccess { get; set; }
        public virtual DbSet<UserAccessCampaign> UserAccessCampaign { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersInRoles> UsersInRoles { get; set; }
        public virtual DbSet<Vatorder> Vatorder { get; set; }
        public virtual DbSet<VatorderMapping> VatorderMapping { get; set; }
        public virtual DbSet<ViewCounter> ViewCounter { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
        public virtual DbSet<Ward> Ward { get; set; }
        public virtual DbSet<WebCustomerFeedback> WebCustomerFeedback { get; set; }
        public virtual DbSet<WebElement> WebElement { get; set; }
        public virtual DbSet<WebElementType> WebElementType { get; set; }
        public virtual DbSet<WebMenu> WebMenu { get; set; }
        public virtual DbSet<WebMenuCategory> WebMenuCategory { get; set; }
        public virtual DbSet<WebPage> WebPage { get; set; }

        // Unable to generate entity type for table 'dbo.CustomerFeedback'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=LUANDNHSE62972\\SQLEXPRESS;Database=Product_Stagging;Trusted_Connection=false;uid=sa;pwd=12345678;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("aaaaaACCOUNT_PK")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.AccountCode)
                    .HasName("IX_AccountCode")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.Level).HasColumnName("Level_");

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Account__Custome__646DCB52");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.MembershipId)
                    .HasConstraintName("FK__Account__Members__56BECA79");
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__Applicat__C93A4C9907F6335A");

                entity.Property(e => e.ApplicationId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(235);

                entity.Property(e => e.Description).HasMaxLength(256);
            });

            modelBuilder.Entity<AreaDelivery>(entity =>
            {
                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.PriceDelivery).HasColumnType("money");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.InverseArea)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_AreaDelivery_AreaDelivery");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentHtml)
                    .IsRequired()
                    .HasColumnName("ContentHTML");

                entity.Property(e => e.DateCreate).HasColumnType("date");

                entity.Property(e => e.Decription).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Article_Store");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.AdminStore)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.AdminStoreId)
                    .HasConstraintName("FK_AspNetUsers_Store");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_AspNetUsers_Customer");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_AspNetUsers_Employee");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.Property(e => e.ApprovePerson).HasMaxLength(255);

                entity.Property(e => e.CheckMax).HasColumnType("datetime");

                entity.Property(e => e.CheckMin).HasColumnType("datetime");

                entity.Property(e => e.FirstCheckAfterShift).HasColumnType("datetime");

                entity.Property(e => e.LastCheckBeforeShift).HasColumnType("datetime");

                entity.Property(e => e.RequestedCheckIn).HasColumnType("datetime");

                entity.Property(e => e.RequestedCheckOut).HasColumnType("datetime");

                entity.Property(e => e.ShiftMax).HasColumnType("datetime");

                entity.Property(e => e.ShiftMin).HasColumnType("datetime");

                entity.Property(e => e.UpdatePerson).HasMaxLength(50);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attendance_Employee");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attendance_Store");

                entity.HasOne(d => d.TimeFram)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.TimeFramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attendance_TimeFrame");
            });

            modelBuilder.Entity<AttendanceDate>(entity =>
            {
                entity.Property(e => e.DateReport).HasColumnType("datetime");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.AttendanceDate)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttendanceDate_Store");
            });

            modelBuilder.Entity<BlogCategory>(entity =>
            {
                entity.Property(e => e.BlogCateNameEn).HasColumnName("BlogCateName_EN");

                entity.Property(e => e.DescriptionEn).HasColumnName("Description_EN");

                entity.Property(e => e.ImageFontAwsomeCss).HasMaxLength(255);

                entity.Property(e => e.IsAllowComment).IsRequired();

                entity.Property(e => e.PageTitleEn).HasColumnName("PageTitle_EN");

                entity.Property(e => e.SeoKeyword).HasMaxLength(255);

                entity.Property(e => e.SeoName).HasMaxLength(255);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.BlogCategory)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogCategory_Store");
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.Property(e => e.AuthorRefer).HasMaxLength(500);

                entity.Property(e => e.BlogCategoryIds).HasMaxLength(255);

                entity.Property(e => e.BlogContentEn).HasColumnName("BlogContent_En");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionEn).HasColumnName("Description_EN");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatePerson).HasMaxLength(255);

                entity.Property(e => e.MetaKeyword).HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .HasColumnName("Name_EN")
                    .HasMaxLength(255);

                entity.Property(e => e.OpeningEn).HasColumnName("Opening_En");

                entity.Property(e => e.PageTitleEn).HasColumnName("PageTitle_En");

                entity.Property(e => e.PublicDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(500);

                entity.Property(e => e.SeoName).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TagIds).HasMaxLength(255);

                entity.Property(e => e.TitleEn).HasColumnName("Title_En");

                entity.Property(e => e.UpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UserApprove).HasMaxLength(500);

                entity.HasOne(d => d.BlogCategory)
                    .WithMany(p => p.BlogPost)
                    .HasForeignKey(d => d.BlogCategoryId)
                    .HasConstraintName("FK_BlogPost_BlogCategory");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.BlogPost)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPost_Store");
            });

            modelBuilder.Entity<BlogPostCollection>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.StoreId })
                    .HasName("IX_BlogPostCollection_StoreId");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionEn).HasColumnName("Description_EN");

                entity.Property(e => e.Link).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameEn)
                    .HasColumnName("Name_EN")
                    .HasMaxLength(255);

                entity.Property(e => e.PicUrl).HasMaxLength(255);

                entity.Property(e => e.SeoDescription).HasMaxLength(255);

                entity.Property(e => e.SeoKeyword).HasMaxLength(255);

                entity.Property(e => e.SeoName).HasMaxLength(255);

                entity.Property(e => e.SeoName1).HasMaxLength(255);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_BlogPostCollection_BlogPostCollection");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.BlogPostCollection)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostCollection_Store");
            });

            modelBuilder.Entity<BlogPostCollectionItem>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.BlogPostCollectionId })
                    .HasName("IX_BlogPostCollectionItem_BlogPostCollectionId");

                entity.HasOne(d => d.BlogPostCollection)
                    .WithMany(p => p.BlogPostCollectionItem)
                    .HasForeignKey(d => d.BlogPostCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostCollectionItem_BlogPostCollection1");
            });

            modelBuilder.Entity<BlogPostCollectionItemMapping>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.BlogPostCollectionId })
                    .HasName("IX_BlogPostCollectionItem_BlogPostCollectionId");

                entity.HasOne(d => d.BlogPostCollection)
                    .WithMany(p => p.BlogPostCollectionItemMapping)
                    .HasForeignKey(d => d.BlogPostCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostCollectionItem_BlogPostCollection");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostCollectionItemMapping)
                    .HasForeignKey(d => d.BlogPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostCollectionItem_BlogPost");
            });

            modelBuilder.Entity<BlogPostImage>(entity =>
            {
                entity.HasIndex(e => new { e.BlogPostId, e.Position, e.Active })
                    .HasName("IX_BlogPostImage_BlogPostId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl).IsRequired();

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostImage)
                    .HasForeignKey(d => d.BlogPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlogPostImage_BlogPost");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.ApiSmskey)
                    .HasColumnName("ApiSMSKey")
                    .HasMaxLength(255);

                entity.Property(e => e.BrandFeatureFilter).HasMaxLength(255);

                entity.Property(e => e.BrandName).HasMaxLength(255);

                entity.Property(e => e.BrandNameSms)
                    .HasColumnName("BrandNameSMS")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ContactPerson).HasMaxLength(255);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultDashBoard).HasMaxLength(250);

                entity.Property(e => e.DefaultDomain).HasMaxLength(255);

                entity.Property(e => e.DefaultImage).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.Pgppassword).HasColumnName("PGPPassword");

                entity.Property(e => e.PgpprivateKey).HasColumnName("PGPPrivateKey");

                entity.Property(e => e.PgppulblicKey).HasColumnName("PGPPulblicKey");

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.RsaprivateKey).HasColumnName("RSAPrivateKey");

                entity.Property(e => e.RsapublicKey).HasColumnName("RSAPublicKey");

                entity.Property(e => e.SecurityApiSmskey)
                    .HasColumnName("SecurityApiSMSKey")
                    .HasMaxLength(255);

                entity.Property(e => e.Smstype).HasColumnName("SMSType");

                entity.Property(e => e.Vatcode)
                    .HasColumnName("VATCode")
                    .HasMaxLength(13);

                entity.Property(e => e.Vattemplate).HasColumnName("VATTemplate");

                entity.Property(e => e.Website).HasMaxLength(255);
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.Property(e => e.CardCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Card)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Card__BrandId__6B1AC8E1");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.Card)
                    .HasForeignKey(d => d.MembershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Card__Membership__24D2692A");
            });

            modelBuilder.Entity<CategoryExtraMapping>(entity =>
            {
                entity.HasOne(d => d.ExtraCategory)
                    .WithMany(p => p.CategoryExtraMappingExtraCategory)
                    .HasForeignKey(d => d.ExtraCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryExtra_ProductCategory1");

                entity.HasOne(d => d.PrimaryCategory)
                    .WithMany(p => p.CategoryExtraMappingPrimaryCategory)
                    .HasForeignKey(d => d.PrimaryCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryExtra_ProductCategory");
            });

            modelBuilder.Entity<CheckFinger>(entity =>
            {
                entity.HasIndex(e => e.LogCode)
                    .HasName("LogCode_Unique")
                    .IsUnique();

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.EmpEnrollNumber).HasMaxLength(50);

                entity.Property(e => e.LogCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MachineNumber).HasMaxLength(50);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CheckFinger)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_CheckFinger_Employee");

                entity.HasOne(d => d.FingerScanMachine)
                    .WithMany(p => p.CheckFinger)
                    .HasForeignKey(d => d.FingerScanMachineId)
                    .HasConstraintName("FK_CheckFinger_FingerScanMachine");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Fax).HasMaxLength(250);

                entity.Property(e => e.Job).HasMaxLength(50);

                entity.Property(e => e.LastVisted).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Organization).HasMaxLength(60);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Contact_Brand");
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.Property(e => e.CostId).HasColumnName("CostID");

                entity.Property(e => e.ApprovedPerson).HasMaxLength(50);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CostCode).HasMaxLength(255);

                entity.Property(e => e.CostDate).HasColumnType("datetime");

                entity.Property(e => e.CostDescription).HasMaxLength(200);

                entity.Property(e => e.LoggedPerson)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaidPerson).HasMaxLength(50);

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Cost)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cost_CostCategory");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Cost)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Cost_Store");
            });

            modelBuilder.Entity<CostCategory>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CostInventoryMapping>(entity =>
            {
                entity.HasKey(e => new { e.CostId, e.ReceiptId });

                entity.Property(e => e.CostId).HasColumnName("CostID");

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.CostInventoryMapping)
                    .HasForeignKey(d => d.CostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostInventoryMapping_Cost");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.CostInventoryMapping)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostInventoryMapping_InventoryReceipt");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.DateUse).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Campagin)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.CampaginId)
                    .HasConstraintName("FK_Vourcher_VoucherCampagin");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Voucher_Store");
            });

            modelBuilder.Entity<CouponCampaign>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.CouponCampaign)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_VoucherCampagin_VourcherProvider");
            });

            modelBuilder.Entity<CouponProvider>(entity =>
            {
                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("Index_BrandId");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountPhone).HasMaxLength(250);

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(250);

                entity.Property(e => e.ContactPersonNumber).HasMaxLength(50);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryInfoDefault).HasColumnName("deliveryInfoDefault");

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookId).HasMaxLength(250);

                entity.Property(e => e.Fax).HasMaxLength(250);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(250);

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picURL")
                    .HasMaxLength(250);

                entity.Property(e => e.Website).HasMaxLength(100);

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .HasConstraintName("FK_Customer_CustomerType");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Customer__Parent__6D031153");
            });

            modelBuilder.Entity<CustomerDevice>(entity =>
            {
                entity.Property(e => e.Fcmtoken)
                    .HasColumnName("FCMToken")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerDevice)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDevice_Customer");
            });

            modelBuilder.Entity<CustomerFilter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthdayFrom).HasColumnType("datetime");

                entity.Property(e => e.BirthdayTo).HasColumnType("datetime");

                entity.Property(e => e.CusTypeId).HasColumnName("CusTypeID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.CustomerFilter)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_CustomerFilter_Brand");
            });

            modelBuilder.Entity<CustomerProductMapping>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerProductMapping)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerProduct_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerProductMapping)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerP__Produ__19A0ADA0");
            });

            modelBuilder.Entity<CustomerStoreReportMapping>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LastVisitDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerStoreReportMapping)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerStore_Customer");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.CustomerStoreReportMapping)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerStore_Store");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.HasIndex(e => e.BrandId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerType1)
                    .HasColumnName("CustomerType")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.CustomerType)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_CustomerType_Brand");
            });

            modelBuilder.Entity<DateHotelReport>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DateProduct>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ProductName)
                    .HasName("IX_DateProduct_ProductName");

                entity.HasIndex(e => e.StoreId);

                entity.HasIndex(e => new { e.CategoryId, e.FinalAmount, e.ProductId, e.ProductName, e.Quantity, e.QuantityAtStore, e.QuantityDelivery, e.QuantityTakeAway, e.TotalAmount, e.StoreId, e.Date })
                    .HasName("nci_wi_DateProduct_21C3BF982A44F5F28A64505961AF1AB7");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryId_");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .HasColumnName("ProductName_")
                    .HasMaxLength(100);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DateProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DateProdu__Produ__17B8652E");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.DateProduct)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DateProduct_Store");
            });

            modelBuilder.Entity<DateProductItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ProductItemId).HasColumnName("ProductItemID");

                entity.Property(e => e.ProductItemName).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.DateProductItem)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_DateProductItem_Store");
            });

            modelBuilder.Entity<DateReport>(entity =>
            {
                entity.HasIndex(e => e.Date);

                entity.HasIndex(e => e.StoreId)
                    .HasName("IX_DateReport_StoreId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(256);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TotalCash).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.DateReport)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DateReport_Store");
            });

            modelBuilder.Entity<DayMode>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DeliveryInfo>(entity =>
            {
                entity.Property(e => e.CustomerName).HasMaxLength(250);

                entity.Property(e => e.IsDefaultDeliveryInfo).HasColumnName("isDefaultDeliveryInfo");

                entity.Property(e => e.Phone)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DeliveryInfo)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_DeliveryInfo_Customer");
            });

            modelBuilder.Entity<DeliveryInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.Ward).HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DeliveryInformation)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_DeliveryInformation_Customer");

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.DeliveryInformation)
                    .HasForeignKey(d => d.DistrictCode)
                    .HasConstraintName("FK_DeliveryInformation_District");

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.DeliveryInformation)
                    .HasForeignKey(d => d.ProvinceCode)
                    .HasConstraintName("FK_DeliveryInformation_Province");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeliveryInformation)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_DeliveryInformation_AspNetUsers");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.Property(e => e.DeviceCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceName).HasMaxLength(100);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Device)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Device__StoreId__013F142A");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.DistrictCode)
                    .HasName("PK_District_1");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DistrictType).HasMaxLength(100);

                entity.Property(e => e.PriceDelivery).HasColumnType("money");

                entity.HasOne(d => d.AreaDistrict)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.AreaDistrictId)
                    .HasConstraintName("FK_District_AreaDelivery");

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.ProvinceCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_District_Province");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DatePersonalCard).HasColumnType("datetime");

                entity.Property(e => e.DateStartWork).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmpEnrollNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.EmployeeHometown).HasMaxLength(1000);

                entity.Property(e => e.EmployeePlaceBorn).HasMaxLength(1000);

                entity.Property(e => e.EmployeeRegency).HasMaxLength(50);

                entity.Property(e => e.MainAddress).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PersonalCardId).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.PlaceOfPersonalCard).HasMaxLength(1000);

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.HasOne(d => d.EmployeeGroup)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmployeeGroupId)
                    .HasConstraintName("FK_Employee_EmployeeGroup");
            });

            modelBuilder.Entity<EmployeeAttribute>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeAttributeMapping>(entity =>
            {
                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.EmployeeAttributeMapping)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_EmployeeAttributeMapping_EmployeeAttribute");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAttributeMapping)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeAttributeMapping_Employee");
            });

            modelBuilder.Entity<EmployeeFingers>(entity =>
            {
                entity.Property(e => e.EmpEnrollNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameEmployeeInMachine).HasMaxLength(50);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmployeeFingers)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EmployeeFingers_Employee");
            });

            modelBuilder.Entity<EmployeeGroup>(entity =>
            {
                entity.Property(e => e.CodeGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameGroup)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<EmployeeInStore>(entity =>
            {
                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeInStore)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeInStore_Employee");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.EmployeeInStore)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeInStore_Store");
            });

            modelBuilder.Entity<EventLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Favorited>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Favorited)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorited_Product1");
            });

            modelBuilder.Entity<FinanceTransaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Camount).HasColumnName("CAmount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Damount).HasColumnName("DAmount");

                entity.Property(e => e.Fdescription)
                    .IsRequired()
                    .HasColumnName("FDescription");

                entity.Property(e => e.FtransCode)
                    .IsRequired()
                    .HasColumnName("FTransCode")
                    .HasMaxLength(250);

                entity.Property(e => e.FtransStatus).HasColumnName("FTransStatus");

                entity.Property(e => e.FtransType).HasColumnName("FTransType");

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.FinanceTransaction)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FTransactionReceipt");
            });

            modelBuilder.Entity<FingerScanMachine>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.MachineCode })
                    .HasName("IX_FingerScanMachine")
                    .IsUnique();

                entity.Property(e => e.BrandOfMachine).HasMaxLength(50);

                entity.Property(e => e.DateOfManufacture).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasMaxLength(50);

                entity.Property(e => e.MachineCode).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.FingerScanMachine)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FingerScanMachine_Store");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Guest>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.RentGroupNavigation)
                    .WithMany(p => p.Guest)
                    .HasForeignKey(d => d.RentGroup)
                    .HasConstraintName("FK_Guest_RentGroup");
            });

            modelBuilder.Entity<ImageCollection>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ImageCollection)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageCollection_Store");
            });

            modelBuilder.Entity<ImageCollectionItem>(entity =>
            {
                entity.Property(e => e.ImageUrl).IsRequired();

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.TitleEng).HasMaxLength(255);

                entity.HasOne(d => d.ImageCollection)
                    .WithMany(p => p.ImageCollectionItem)
                    .HasForeignKey(d => d.ImageCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageCollectionItem_ImageCollection");
            });

            modelBuilder.Entity<InventoryChecking>(entity =>
            {
                entity.HasKey(e => e.CheckingId)
                    .HasName("PK__Inventor__4D7B4ADD145C0A3F");

                entity.Property(e => e.CheckingDate).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<InventoryCheckingItem>(entity =>
            {
                entity.HasKey(e => e.InventoryCheckingId);

                entity.Property(e => e.InventoryCheckingId).HasColumnName("InventoryCheckingID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Checking)
                    .WithMany(p => p.InventoryCheckingItem)
                    .HasForeignKey(d => d.CheckingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryCheckingItem_InventoryChecking");
            });

            modelBuilder.Entity<InventoryDateReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_InventoryReport");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InventoryDateReport)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryReport_Store");
            });

            modelBuilder.Entity<InventoryDateReportItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ReportId })
                    .HasName("PK__ReportIt__3F2557656FE99F9F");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InventoryDateReportItem)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__ReportIte__ItemI__55009F39");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.InventoryDateReportItem)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportItem_InventoryReport");
            });

            modelBuilder.Entity<InventoryReceipt>(entity =>
            {
                entity.HasKey(e => e.ReceiptId);

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.InStore)
                    .WithMany(p => p.InventoryReceiptInStore)
                    .HasForeignKey(d => d.InStoreId)
                    .HasConstraintName("FK_InventoryReceipt_Store4");

                entity.HasOne(d => d.OutStore)
                    .WithMany(p => p.InventoryReceiptOutStore)
                    .HasForeignKey(d => d.OutStoreId)
                    .HasConstraintName("FK_InventoryReceipt_Store5");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.InventoryReceipt)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_InventoryReceipt_Provider");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InventoryReceiptStore)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_InventoryReceipt_Store3");
            });

            modelBuilder.Entity<InventoryReceiptItem>(entity =>
            {
                entity.HasKey(e => new { e.ReceiptId, e.ItemId })
                    .HasName("PK_ReceiptItem");

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.ExportedDate).HasColumnType("date");

                entity.Property(e => e.IsUnit1).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InventoryReceiptItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptItem_ProductItem");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.InventoryReceiptItem)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptItem_InventoryReceipt");
            });

            modelBuilder.Entity<InventoryTemplateReport>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_InventoryReportTemplate_BrandId");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.InventoryTemplateReport)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryTemplateReport_Brand");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.StoreId, e.EnglishName })
                    .HasName("IX_Language_List");

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Language)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Language_Store");
            });

            modelBuilder.Entity<LanguageKey>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.StoreId, e.Name })
                    .HasName("IX_LanguageKey_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.LanguageKey)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageKey_Store");
            });

            modelBuilder.Entity<LanguageValue>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.LanguageKeyId, e.LanguageId })
                    .HasName("IX_LanguageValue_LanguageKeyId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguageValue)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageValue_Language");

                entity.HasOne(d => d.LanguageKey)
                    .WithMany(p => p.LanguageValue)
                    .HasForeignKey(d => d.LanguageKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageValue_LanguageKey");
            });

            modelBuilder.Entity<MachineConnect>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.ConnectTime).HasColumnType("datetime");

                entity.Property(e => e.MachineCode).HasMaxLength(50);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Csv)
                    .HasColumnName("CSV")
                    .HasMaxLength(10);

                entity.Property(e => e.Level).HasColumnName("_Level");

                entity.Property(e => e.MembershipCode).HasMaxLength(50);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Membership)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Membership_Brand");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Membership)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Membership_Customer");

                entity.HasOne(d => d.MembershipType)
                    .WithMany(p => p.Membership)
                    .HasForeignKey(d => d.MembershipTypeId)
                    .HasConstraintName("FK_Membership_MembershipType");
            });

            modelBuilder.Entity<MembershipType>(entity =>
            {
                entity.Property(e => e.AppendCode).HasMaxLength(10);

                entity.Property(e => e.BrandId).HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.MembershipType)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Membershi__Brand__7D046EF2");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Action).HasMaxLength(250);

                entity.Property(e => e.Area).HasMaxLength(250);

                entity.Property(e => e.Controller).HasMaxLength(250);

                entity.Property(e => e.IconCss).HasMaxLength(250);

                entity.Property(e => e.MenuText).HasMaxLength(250);

                entity.HasOne(d => d.ParentMenu)
                    .WithMany(p => p.InverseParentMenu)
                    .HasForeignKey(d => d.ParentMenuId)
                    .HasConstraintName("FK_Menu_Menu");
            });

            modelBuilder.Entity<MenuRole>(entity =>
            {
                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuRole)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK__MenuRole__MenuId__12F3B011");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MenuRole)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__MenuRole__RoleId__13E7D44A");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DescriptionEn).HasColumnName("Description_En");

                entity.Property(e => e.PicUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TitleEn).HasColumnName("Title_En");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.RentId)
                    .HasName("PK__Rent__7908F585");

                entity.HasIndex(e => e.CheckInDate)
                    .HasName("IX_Rent_CheckInDate");

                entity.HasIndex(e => e.CheckInPerson);

                entity.HasIndex(e => e.CheckinHour)
                    .HasName("IX_Rent_CheckinHour");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_Order_CustomerId");

                entity.HasIndex(e => e.FinalAmount);

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("nci_wi_Order_D69134FCCC98CE4F0A9AE2B0B1EC5F1E");

                entity.HasIndex(e => e.OrderStatus)
                    .HasName("IX_Rent_OrderStatus");

                entity.HasIndex(e => e.OrderType)
                    .HasName("IX_Rent_OrderType");

                entity.HasIndex(e => e.StoreId);

                entity.HasIndex(e => new { e.Att1, e.CustomerId, e.Discount, e.DiscountOrderDetail, e.FinalAmount, e.InvoiceId, e.OrderType, e.TotalAmount, e.StoreId, e.CheckInDate })
                    .HasName("nci_wi_Order_B20F68D720CF9F0E6AEC9A55D2F5CBD2");

                entity.Property(e => e.RentId).HasColumnName("RentID");

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovePerson).HasMaxLength(50);

                entity.Property(e => e.ArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.Att1).HasMaxLength(250);

                entity.Property(e => e.Att2).HasMaxLength(250);

                entity.Property(e => e.Att3).HasMaxLength(250);

                entity.Property(e => e.Att4).HasMaxLength(250);

                entity.Property(e => e.Att5).HasMaxLength(250);

                entity.Property(e => e.BookingDate).HasColumnType("datetime");

                entity.Property(e => e.CheckInDate).HasColumnType("datetime");

                entity.Property(e => e.CheckInPerson).HasMaxLength(50);

                entity.Property(e => e.CheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.CheckOutPerson).HasMaxLength(50);

                entity.Property(e => e.CheckinHour).HasComputedColumnSql("(datepart(hour,[CheckInDate]))");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.DeliveryPhone).HasMaxLength(50);

                entity.Property(e => e.DeliveryReceiver).HasMaxLength(255);

                entity.Property(e => e.DepartureDate).HasColumnType("datetime");

                entity.Property(e => e.FeeDescription).HasMaxLength(250);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasMaxLength(50);

                entity.Property(e => e.IsSync).HasColumnName("isSync");

                entity.Property(e => e.LastModifiedOrderDetail).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedPayment).HasColumnType("datetime");

                entity.Property(e => e.LastRecordDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailsTotalQuantity).HasComputedColumnSql("([dbo].[CalculateRentTotalQuantity]([RentID]))");

                entity.Property(e => e.PriceGroupId).HasColumnName("PriceGroupID");

                entity.Property(e => e.Receiver).HasMaxLength(250);

                entity.Property(e => e.RoomId).HasDefaultValueSql("((5))");

                entity.Property(e => e.ServedPerson).HasMaxLength(50);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.SubRentGroupId).HasColumnName("SubRentGroupID");

                entity.Property(e => e.TableCode).HasMaxLength(50);

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Vatamount).HasColumnName("VATAmount");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.DistrictCode)
                    .HasConstraintName("FK_Order_District");

                entity.HasOne(d => d.PriceGroup)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.PriceGroupId)
                    .HasConstraintName("FK_Order_PriceGroup");

                entity.HasOne(d => d.PromotionPartner)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.PromotionPartnerId)
                    .HasConstraintName("FK_PromotionPartnerOrder");

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ProvinceCode)
                    .HasConstraintName("FK_Order_Province");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Order_Room");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Order_Store");

                entity.HasOne(d => d.SubRentGroup)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.SubRentGroupId)
                    .HasConstraintName("FK_Order_SubRentGroup");

                entity.HasOne(d => d.WardCodeNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.WardCode)
                    .HasConstraintName("FK_Order_Ward");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasIndex(e => e.FinalAmount);

                entity.HasIndex(e => e.OrderDate);

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => new { e.RentId, e.Quantity })
                    .HasName("IX_OrderDetail_RentID");

                entity.HasIndex(e => new { e.FinalAmount, e.Quantity, e.RentId, e.TotalAmount, e.ProductId, e.OrderDate })
                    .HasName("nci_wi_OrderDetail_46DF70E2273DAEA11EDD7F2F89BC4EE4");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.IsAddition)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailAtt1).HasMaxLength(255);

                entity.Property(e => e.OrderDetailAtt2).HasMaxLength(255);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RentId).HasColumnName("RentID");

                entity.Property(e => e.StoreId).HasComputedColumnSql("([dbo].[CurrentOrderDetailStore2]([RentID]))");

                entity.HasOne(d => d.OrderDetailPromotionMapping)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OrderDetailPromotionMappingId)
                    .HasConstraintName("FK_OrderDetail_OrderDetailPromotionMapping");

                entity.HasOne(d => d.OrderPromotionMapping)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OrderPromotionMappingId)
                    .HasConstraintName("FK_OrderDetail_OrderPromotionMapping");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_OrderDetail_OrderDetail");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Product");

                entity.HasOne(d => d.Rent)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.RentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Order");
            });

            modelBuilder.Entity<OrderDetailPromotionMapping>(entity =>
            {
                entity.Property(e => e.DiscountAmount).HasColumnType("money");

                entity.HasOne(d => d.OrderDetailNavigation)
                    .WithMany(p => p.OrderDetailPromotionMappingNavigation)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetailPromotionMapping_OrderDetail");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.OrderDetailPromotionMapping)
                    .HasForeignKey(d => d.PromotionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetailPromotionMapping_Promotion");
            });

            modelBuilder.Entity<OrderFeeItem>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.PriceGroup)
                    .WithMany(p => p.OrderFeeItem)
                    .HasForeignKey(d => d.PriceGroupId)
                    .HasConstraintName("FK_OrderFeeItem_PriceGroup");

                entity.HasOne(d => d.Rent)
                    .WithMany(p => p.OrderFeeItem)
                    .HasForeignKey(d => d.RentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFeeItem_Order");
            });

            modelBuilder.Entity<OrderGroup>(entity =>
            {
                entity.Property(e => e.BookingDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.GetRoomDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderGroup)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_RentGroup_Customer");
            });

            modelBuilder.Entity<OrderPromotionMapping>(entity =>
            {
                entity.Property(e => e.DiscountAmount).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderPromotionMapping)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderPromotionMapping_Order");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.OrderPromotionMapping)
                    .HasForeignKey(d => d.PromotionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderPromotionMapping_Promotion");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvatarUrl).HasColumnName("AvatarURL");

                entity.Property(e => e.PartnerAddress).HasMaxLength(255);

                entity.Property(e => e.PartnerCode).HasMaxLength(200);

                entity.Property(e => e.PartnerName).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(20);
            });

            modelBuilder.Entity<PartnerMapping>(entity =>
            {
                entity.HasIndex(e => new { e.BrandId, e.PartnerId })
                    .HasName("UC_PartnerMapping")
                    .IsUnique();

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.PartnerMapping)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerMapping_Brand");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerMapping)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PartnerMa__Partn__49EEDF40");
            });

            modelBuilder.Entity<PaySlip>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PaySlip)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_PaySlip_Employee");

                entity.HasOne(d => d.PayrollPeriod)
                    .WithMany(p => p.PaySlip)
                    .HasForeignKey(d => d.PayrollPeriodId)
                    .HasConstraintName("FK_PaySlip_PayrollPeriod");

                entity.HasOne(d => d.TemplateDetailMapping)
                    .WithMany(p => p.PaySlip)
                    .HasForeignKey(d => d.TemplateDetailMappingId)
                    .HasConstraintName("FK_PaySlip_TemplateDetailMapping1");
            });

            modelBuilder.Entity<PaySlipItem>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.PaySlip)
                    .WithMany(p => p.PaySlipItem)
                    .HasForeignKey(d => d.PaySlipId)
                    .HasConstraintName("FK_PaySlipItem_PaySlip");

                entity.HasOne(d => d.PayrollDetail)
                    .WithMany(p => p.PaySlipItem)
                    .HasForeignKey(d => d.PayrollDetailId)
                    .HasConstraintName("FK_PaySlipItem_PayrollDetail");
            });

            modelBuilder.Entity<PaySlipTemplate>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasIndex(e => e.PayTime)
                    .HasName("IX_Payment_Time_DESC");

                entity.HasIndex(e => e.ToRentId)
                    .HasName("nci_wi_Payment_37E0BD95D26EFCA99E2F9EA13BD8536B");

                entity.HasIndex(e => e.Type);

                entity.HasIndex(e => new { e.ToRentId, e.PayTime })
                    .HasName("nci_wi_Payment_9DA8C0FD3FF745B2102710EED58148E1");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CardCode).HasMaxLength(50);

                entity.Property(e => e.CostId).HasColumnName("CostID");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fcamount)
                    .HasColumnName("FCAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentCode).HasMaxLength(250);

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.ToRentId).HasColumnName("ToRentID");

                entity.Property(e => e.TransactionCodeRef).HasMaxLength(250);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Payment_Account");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_Payment_Card");

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.CostId)
                    .HasConstraintName("FK_Payment_Cost");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.ReceiptId)
                    .HasConstraintName("FK__Payment__Receipt__0C7BBCAC");

                entity.HasOne(d => d.ToRent)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.ToRentId)
                    .HasConstraintName("FK_Payment_Order");
            });

            modelBuilder.Entity<PaymentPartner>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Att1).HasColumnType("text");

                entity.Property(e => e.Att2).HasColumnType("text");

                entity.Property(e => e.Att3).HasColumnType("text");

                entity.Property(e => e.Att4).HasColumnType("text");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ContactPerson).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.PartnerName).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(255);
            });

            modelBuilder.Entity<PaymentReport>(entity =>
            {
                entity.HasIndex(e => e.Date);

                entity.HasIndex(e => e.StoreId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PaymentReport)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReport_Store");
            });

            modelBuilder.Entity<PayrollCategory>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PayrollDetail>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(250);

                entity.HasOne(d => d.PayrollCategory)
                    .WithMany(p => p.PayrollDetail)
                    .HasForeignKey(d => d.PayrollCategoryId)
                    .HasConstraintName("FK_PayrollDetail_PayrollCategory");
            });

            modelBuilder.Entity<PayrollPeriod>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.PaySlipTemplate)
                    .WithMany(p => p.PayrollPeriod)
                    .HasForeignKey(d => d.PaySlipTemplateId)
                    .HasConstraintName("FK_PayrollPeriod_PaySlipTemplate");
            });

            modelBuilder.Entity<PayslipAttribute>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PayslipAttributeMapping>(entity =>
            {
                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.PayslipAttributeMapping)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_PayslipAttributeMapping_PayslipAttribute");

                entity.HasOne(d => d.Payslip)
                    .WithMany(p => p.PayslipAttributeMapping)
                    .HasForeignKey(d => d.PayslipId)
                    .HasConstraintName("FK_PayslipAttributeMapping_PaySlip");
            });

            modelBuilder.Entity<Pos>(entity =>
            {
                entity.Property(e => e.PosId).ValueGeneratedNever();

                entity.Property(e => e.MacId).HasMaxLength(20);

                entity.Property(e => e.PosCode).HasMaxLength(10);

                entity.Property(e => e.PosConfig).HasColumnType("ntext");
            });

            modelBuilder.Entity<PosConfig>(entity =>
            {
                entity.HasIndex(e => e.PosFileId);

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.PosFile)
                    .WithMany(p => p.PosConfig)
                    .HasForeignKey(d => d.PosFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PosConfig_PosFile");
            });

            modelBuilder.Entity<PosFile>(entity =>
            {
                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.StoreId);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Version).HasMaxLength(10);
            });

            modelBuilder.Entity<PriceAddition>(entity =>
            {
                entity.HasKey(e => e.AdditionPriceId)
                    .HasName("PK_AdditionPrice");

                entity.Property(e => e.AdditionPriceId).HasColumnName("AdditionPriceID");

                entity.Property(e => e.EarlyHourRange)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EarlyPriceRange)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LateHourRange)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LatePriceRange)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PriceGroup>(entity =>
            {
                entity.Property(e => e.PriceGroupId).HasColumnName("PriceGroupID");

                entity.Property(e => e.EndNightTime).HasColumnType("datetime");

                entity.Property(e => e.NightAdditionPriceId).HasColumnName("NightAdditionPriceID");

                entity.Property(e => e.PriceGroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDayTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PriceNight>(entity =>
            {
                entity.HasKey(e => e.RoomPriceId)
                    .HasName("PK__NightPrice__4865BE2A");

                entity.Property(e => e.RoomPriceId).HasColumnName("RoomPriceID");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2016:01:01')");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.PriceGroupId).HasColumnName("PriceGroupID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.PriceGroup)
                    .WithMany(p => p.PriceNight)
                    .HasForeignKey(d => d.PriceGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceNight_PriceGroup");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.AlterNativeCode).HasMaxLength(100);

                entity.Property(e => e.AvailableDate).HasColumnType("datetime");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.PicUrl).HasColumnName("PicURL");

                entity.Property(e => e.PriceCogs).HasColumnName("PriceCOGS");

                entity.Property(e => e.ProductName).HasMaxLength(500);

                entity.Property(e => e.ProductNameEng).HasMaxLength(500);

                entity.Property(e => e.SeoKeyWords).HasMaxLength(500);

                entity.Property(e => e.SeoName).HasMaxLength(255);

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductCategory");

                entity.HasOne(d => d.ProductBrand)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductBrandId)
                    .HasConstraintName("FK_Product_ProductBrand");
            });

            modelBuilder.Entity<ProductBrand>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Slug).HasMaxLength(250);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.CateId)
                    .HasName("PK__ProductC__27638D745441852A");

                entity.Property(e => e.CateId).HasColumnName("CateID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AdjustmentNote).HasMaxLength(250);

                entity.Property(e => e.BannerUrl).HasMaxLength(255);

                entity.Property(e => e.CateName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CateNameEng).HasMaxLength(50);

                entity.Property(e => e.ImageFontAwsomeCss)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('glass')");

                entity.Property(e => e.IsDisplayed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PicUrl).HasMaxLength(255);

                entity.Property(e => e.SeoDescription).HasMaxLength(500);

                entity.Property(e => e.SeoKeyword).HasMaxLength(255);

                entity.Property(e => e.SeoName).HasMaxLength(255);

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_ProductCategory_Brand");

                entity.HasOne(d => d.ParentCate)
                    .WithMany(p => p.InverseParentCate)
                    .HasForeignKey(d => d.ParentCateId)
                    .HasConstraintName("FK_ProductCategory_ProductCategory");
            });

            modelBuilder.Entity<ProductCollection>(entity =>
            {
                entity.HasIndex(e => e.StoreId);

                entity.Property(e => e.BannerUrl).HasMaxLength(255);

                entity.Property(e => e.Link).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameEng).HasMaxLength(255);

                entity.Property(e => e.Seo)
                    .HasColumnName("SEO")
                    .HasMaxLength(255);

                entity.Property(e => e.Seodescription)
                    .HasColumnName("SEODescription")
                    .HasMaxLength(255);

                entity.Property(e => e.Seokeyword)
                    .HasColumnName("SEOKeyword")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ProductCollection)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_ProductCollection_Brand");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProductCollection)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCollection_Store");
            });

            modelBuilder.Entity<ProductCollectionItemMapping>(entity =>
            {
                entity.HasOne(d => d.ProductCollection)
                    .WithMany(p => p.ProductCollectionItemMapping)
                    .HasForeignKey(d => d.ProductCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCollectionItem_ProductCollection");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCollectionItemMapping)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCollectionItem_Product");
            });

            modelBuilder.Entity<ProductComboDetail>(entity =>
            {
                entity.HasKey(e => new { e.ComboId, e.ProductId })
                    .HasName("ComboID_ProductID");

                entity.Property(e => e.ComboId).HasColumnName("ComboID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Combo)
                    .WithMany(p => p.ProductComboDetailCombo)
                    .HasForeignKey(d => d.ComboId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductCo__Combo__26068485");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductComboDetailProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComboDetail_Product");
            });

            modelBuilder.Entity<ProductDetailMapping>(entity =>
            {
                entity.HasKey(e => e.ProductDetailId)
                    .HasName("PK_ProductDetail");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.StoreId);

                entity.Property(e => e.ProductDetailId).HasColumnName("ProductDetailID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDetailMapping)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductDetailMapping_Product");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProductDetailMapping)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_ProductDetail_Store");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.ProductId, e.Position })
                    .HasName("IX_ProductImage_ProduceId");

                entity.Property(e => e.ImageUrl).IsRequired();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImage)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductIm__Produ__16C440F5");
            });

            modelBuilder.Entity<ProductImageCollection>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ProductImageCollectionItemMapping>(entity =>
            {
                entity.Property(e => e.ImageUrl).IsRequired();

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.ImageCollection)
                    .WithMany(p => p.ProductImageCollectionItemMapping)
                    .HasForeignKey(d => d.ImageCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductImageCollectionItemMapping_ProductImageCollection");
            });

            modelBuilder.Entity<ProductItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__tmp_ms_x__727E83EB4301EA8F");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl).HasMaxLength(100);

                entity.Property(e => e.ItemCode).HasMaxLength(255);

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.Unit2).HasMaxLength(50);

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.ProductItem)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductItem_ItemCategory");
            });

            modelBuilder.Entity<ProductItemCategory>(entity =>
            {
                entity.HasKey(e => e.CateId)
                    .HasName("PK_ItemCategory");

                entity.Property(e => e.CateId).HasColumnName("CateID");

                entity.Property(e => e.CateName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductItemCompositionMapping>(entity =>
            {
                entity.HasKey(e => new { e.ProducId, e.ItemId })
                    .HasName("PK_Composition_1");

                entity.Property(e => e.ProducId).HasColumnName("ProducID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ProductItemCompositionMapping)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compositi__ItemI__76969D2E");

                entity.HasOne(d => d.Produc)
                    .WithMany(p => p.ProductItemCompositionMapping)
                    .HasForeignKey(d => d.ProducId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compositi__Produ__778AC167");
            });

            modelBuilder.Entity<ProductSpecification>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.ProductId, e.Position })
                    .HasName("IX_ProductSpecification_ProductId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecification)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductSp__Produ__15D01CBC");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Profiles__1788CC4C76969D2E");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PropertyValueBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValueStrings)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Profiles)
                    .HasForeignKey<Profiles>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserProfile");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasIndex(e => e.PromotionCode)
                    .HasName("UK_Promotion")
                    .IsUnique();

                entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ImageCss).HasMaxLength(50);

                entity.Property(e => e.PromotionClassName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PromotionName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PromotionDetail>(entity =>
            {
                entity.Property(e => e.PromotionDetailId).HasColumnName("PromotionDetailID");

                entity.Property(e => e.BuyProductCode).HasMaxLength(250);

                entity.Property(e => e.DiscountAmount).HasColumnType("money");

                entity.Property(e => e.GiftProductCode).HasMaxLength(50);

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PromotionDetailCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RegExCode).HasMaxLength(50);

                entity.HasOne(d => d.PromotionCodeNavigation)
                    .WithMany(p => p.PromotionDetail)
                    .HasPrincipalKey(p => p.PromotionCode)
                    .HasForeignKey(d => d.PromotionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PromotionDetail_Promotion");
            });

            modelBuilder.Entity<PromotionPartner>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CommissionRate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ContactPerson).HasMaxLength(255);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.OrderPrefix)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerName).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Website).HasMaxLength(255);
            });

            modelBuilder.Entity<PromotionStoreMapping>(entity =>
            {
                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.PromotionStoreMapping)
                    .HasForeignKey(d => d.PromotionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PromotionStoreMapping_Promotion");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PromotionStoreMapping)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PromotionStoreMapping_Store");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.AccountNo).HasMaxLength(15);

                entity.Property(e => e.License).HasMaxLength(255);

                entity.Property(e => e.ManagerName).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.ProviderName).HasMaxLength(50);

                entity.Property(e => e.Vatcode)
                    .HasColumnName("VATCode")
                    .HasMaxLength(13);
            });

            modelBuilder.Entity<ProviderProductItemMapping>(entity =>
            {
                entity.HasKey(e => e.ProviderProductItemId)
                    .HasName("PK_ProviderProductItem");

                entity.Property(e => e.ProductItemId).HasColumnName("ProductItemID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.ProductItem)
                    .WithMany(p => p.ProviderProductItemMapping)
                    .HasForeignKey(d => d.ProductItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderProductItem_ProductItem");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderProductItemMapping)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderProductItem_Provider");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.ProvinceCode)
                    .HasName("PK_Province_1");

                entity.Property(e => e.BasePriceDelivery).HasColumnType("money");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProvinceType).HasMaxLength(100);

                entity.HasOne(d => d.AreaProvince)
                    .WithMany(p => p.Province)
                    .HasForeignKey(d => d.AreaProvinceId)
                    .HasConstraintName("FK_Province_AreaDelivery");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_RatingProduct_Customer");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_RatingProduct_Order");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Rating_Rating");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Rating_Product");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Rating_Store");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RatingProduct_AspNetUsers");
            });

            modelBuilder.Entity<RatingStar>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedPersonId)
                    .HasColumnName("ApprovedPersonID")
                    .HasMaxLength(128);

                entity.Property(e => e.ApprovedPersonName).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ReceiptCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ReceiptDescription).IsRequired();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovedPerson)
                    .WithMany(p => p.Receipt)
                    .HasForeignKey(d => d.ApprovedPersonId)
                    .HasConstraintName("FK_ReceiptApprovedPerson");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Receipt)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ReceiptCustomer");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Receipt)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_ReceiptOrder");
            });

            modelBuilder.Entity<ReportTracking>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdatePerson).HasMaxLength(50);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ReportTracking)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTracking_Store");
            });

            modelBuilder.Entity<RequestHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ControllerName).HasMaxLength(255);

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.RequestTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Roles__8AFACE1A06CD04F7");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleApplication");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomId)
                    .HasColumnName("RoomID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.FloorId).HasColumnName("FloorID");

                entity.Property(e => e.RoomDescription).HasMaxLength(250);

                entity.Property(e => e.RoomName).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room__CategoryID__76EBA2E9");

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.FloorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room__FloorID__4589517F");
            });

            modelBuilder.Entity<RoomCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IconUrl)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShortNane)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.RoomCategory)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_RoomCategory_Store");
            });

            modelBuilder.Entity<RoomCategoryPriceGroupMapping>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PriceGroupId })
                    .HasName("PK_CategoryPriceGroup");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.PriceGroupId).HasColumnName("PriceGroupID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.RoomCategoryPriceGroupMapping)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryPriceGroup_RoomCategory");

                entity.HasOne(d => d.PriceGroup)
                    .WithMany(p => p.RoomCategoryPriceGroupMapping)
                    .HasForeignKey(d => d.PriceGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryPriceGroup_PriceGroup");
            });

            modelBuilder.Entity<RoomFloor>(entity =>
            {
                entity.HasKey(e => e.FloorId)
                    .HasName("PK__RoomFloo__49D1E86B2B3F6F97");

                entity.Property(e => e.FloorId).HasColumnName("FloorID");

                entity.Property(e => e.FloorName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SalaryHour>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Unique_SalaryHour")
                    .IsUnique();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExistCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatePerson).HasMaxLength(50);
            });

            modelBuilder.Entity<SalaryRule>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TimeModeRule)
                    .WithMany(p => p.SalaryRule)
                    .HasForeignKey(d => d.TimeModeRuleId)
                    .HasConstraintName("FK_SalaryRule_TimeModeRule");
            });

            modelBuilder.Entity<ShiftRegister>(entity =>
            {
                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ShiftRegister)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShiftRegi__Emplo__18227982");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CloseTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultAdminPassword).HasMaxLength(20);

                entity.Property(e => e.DefaultDashBoard).HasMaxLength(250);

                entity.Property(e => e.District).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.IsAvailable).HasColumnName("isAvailable");

                entity.Property(e => e.Lat).HasMaxLength(256);

                entity.Property(e => e.Lon).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OpenTime).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.StoreCode).HasMaxLength(10);

                entity.Property(e => e.StoreConfig).HasColumnType("ntext");

                entity.Property(e => e.StoreFeatureFilter).HasMaxLength(255);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Store_Brand");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Store_Group");
            });

            modelBuilder.Entity<StoreDomain>(entity =>
            {
                entity.HasIndex(e => new { e.StoreId, e.Active })
                    .HasName("IX_StoreDomain_StoreId");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Protocol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreDomain)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreDomain_Store");
            });

            modelBuilder.Entity<StoreGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.StoreGroup)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreGroup_Brand");
            });

            modelBuilder.Entity<StoreGroupMapping>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StoreGroupId).HasColumnName("StoreGroupID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.StoreGroup)
                    .WithMany(p => p.StoreGroupMapping)
                    .HasForeignKey(d => d.StoreGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreGroupMapping_StoreGroup");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreGroupMapping)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreGroupMapping_Store");
            });

            modelBuilder.Entity<StoreTheme>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(100);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ThemeName).IsRequired();

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreTheme)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreTheme_Store");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.StoreTheme)
                    .HasForeignKey(d => d.ThemeId)
                    .HasConstraintName("FK_StoreTheme_Theme");
            });

            modelBuilder.Entity<StoreUser>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.StoreId });

                entity.Property(e => e.Username).HasMaxLength(256);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreUser)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreUser_Store");
            });

            modelBuilder.Entity<StoreWebRoute>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.StoreId })
                    .HasName("IX_StoreWebRoute_StoreId");

                entity.Property(e => e.LayoutName).HasMaxLength(255);

                entity.Property(e => e.Path).IsRequired();

                entity.Property(e => e.ViewName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreWebRoute)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreWebRoute_Store");

                entity.HasOne(d => d.StoreWebRouteCopy)
                    .WithMany(p => p.InverseStoreWebRouteCopy)
                    .HasForeignKey(d => d.StoreWebRouteCopyId)
                    .HasConstraintName("FK_StoreWebRoute_StoreWebRoute");
            });

            modelBuilder.Entity<StoreWebRouteModel>(entity =>
            {
                entity.HasIndex(e => new { e.StoreWebRouteId, e.Active })
                    .HasName("IX_StoreWebRouteModel_StoreWebRouteId");

                entity.Property(e => e.IdRouteValueName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.StoreWebRoute)
                    .WithMany(p => p.StoreWebRouteModel)
                    .HasForeignKey(d => d.StoreWebRouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreWebRouteModel_StoreWebRoute");
            });

            modelBuilder.Entity<StoreWebSetting>(entity =>
            {
                entity.HasIndex(e => new { e.StoreId, e.Name })
                    .HasName("IX_StoreWebSetting_Search");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreWebSetting)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreWebSetting_Store");
            });

            modelBuilder.Entity<StoreWebViewCounter>(entity =>
            {
                entity.HasIndex(e => new { e.Active, e.StoreId })
                    .HasName("IX_StoreWebViewCounter_StoreId");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreWebViewCounter)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreWebViewCounter_Store");
            });

            modelBuilder.Entity<SubRentGroup>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RentGroupId).HasColumnName("RentGroupID");

                entity.Property(e => e.ServicedQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SourceId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.RentGroup)
                    .WithMany(p => p.SubRentGroup)
                    .HasForeignKey(d => d.RentGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubRentGroup_RentGroup");

                entity.HasOne(d => d.RoomTypeNavigation)
                    .WithMany(p => p.SubRentGroup)
                    .HasForeignKey(d => d.RoomType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubRentGroup_RoomCategory");
            });

            modelBuilder.Entity<SystemPartnerMapping>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Att1).HasColumnType("text");

                entity.Property(e => e.Att2).HasColumnType("text");

                entity.Property(e => e.Att3).HasColumnType("text");

                entity.Property(e => e.Att4).HasColumnType("text");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagNameEn).HasColumnName("TagName_EN");

                entity.Property(e => e.Type).HasMaxLength(250);
            });

            modelBuilder.Entity<TagMapping>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TagMapping)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TagMapping_BlogCategory");

                entity.HasOne(d => d.TagBlog)
                    .WithMany(p => p.TagMapping)
                    .HasForeignKey(d => d.TagBlogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TagMapping_BlogPost");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagMapping)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TagMapping_Tag");
            });

            modelBuilder.Entity<TaskDetail>(entity =>
            {
                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TemplateDetailMapping>(entity =>
            {
                entity.HasOne(d => d.PaySlipTemplate)
                    .WithMany(p => p.TemplateDetailMapping)
                    .HasForeignKey(d => d.PaySlipTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateDetailMapping_PaySlipTemplate");

                entity.HasOne(d => d.PayrollDetail)
                    .WithMany(p => p.TemplateDetailMapping)
                    .HasForeignKey(d => d.PayrollDetailId)
                    .HasConstraintName("FK_TemplateDetailMapping_PayrollDetail");
            });

            modelBuilder.Entity<TemplateReportProductItemMapping>(entity =>
            {
                entity.HasOne(d => d.InventoryTemplateReport)
                    .WithMany(p => p.TemplateReportProductItemMapping)
                    .HasForeignKey(d => d.InventoryTemplateReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateReportProductItemMapping_InventoryTemplateReport");

                entity.HasOne(d => d.ProductItem)
                    .WithMany(p => p.TemplateReportProductItemMapping)
                    .HasForeignKey(d => d.ProductItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateReportProductItemMapping_ProductItem");
            });

            modelBuilder.Entity<TemplateRuleMapping>(entity =>
            {
                entity.HasOne(d => d.PaySlipTemplate)
                    .WithMany(p => p.TemplateRuleMapping)
                    .HasForeignKey(d => d.PaySlipTemplateId)
                    .HasConstraintName("FK_TemplateRuleMapping_PaySlipTemplate");

                entity.HasOne(d => d.SalaryRule)
                    .WithMany(p => p.TemplateRuleMapping)
                    .HasForeignKey(d => d.SalaryRuleId)
                    .HasConstraintName("FK_TemplateRuleMapping_SalaryRule");
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(100);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ThemeFolderUrl).IsRequired();

                entity.Property(e => e.ThemeName).IsRequired();

                entity.Property(e => e.ThemeStyle).IsRequired();
            });

            modelBuilder.Entity<TimeFrame>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.EmployeeGroup)
                    .WithMany(p => p.TimeFrame)
                    .HasForeignKey(d => d.EmployeeGroupId)
                    .HasConstraintName("FK_TimeFrame_EmployeeGroup");
            });

            modelBuilder.Entity<TimeModeRule>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.DayMode)
                    .WithMany(p => p.TimeModeRule)
                    .HasForeignKey(d => d.DayModeId)
                    .HasConstraintName("FK_TimeModeRule_DayMode");

                entity.HasOne(d => d.TimeModeType)
                    .WithMany(p => p.TimeModeRule)
                    .HasForeignKey(d => d.TimeModeTypeId)
                    .HasConstraintName("FK_TimeModeRule_TimeModeType");
            });

            modelBuilder.Entity<TimeModeType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TokenUser>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(256);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasIndex(e => e.AccountId);

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.StoreId);

                entity.HasIndex(e => new { e.AccountId, e.Amount, e.BrandId, e.CurrencyCode, e.Fcamount, e.IsIncreaseTransaction, e.Notes, e.Status, e.TransactionType, e.UserId, e.StoreId, e.Date })
                    .HasName("nci_wi_Transaction_3AE4E670D3226EFBC5C45152B8B0C0E1");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Fcamount)
                    .HasColumnName("FCAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PaymentCodeRef).HasMaxLength(250);

                entity.Property(e => e.TransactionCode).HasMaxLength(250);

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Account");
            });

            modelBuilder.Entity<TransactionIndex2244ceaa24f54fdeBd5fBaf8ea08cdc4>(entity =>
            {
                entity.ToTable("_TransactionIndex_2244ceaa-24f5-4fde-bd5f-baf8ea08cdc4");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<UserAccess>(entity =>
            {
                entity.Property(e => e.UserAccessCampaignId).HasColumnName("UserAccess_CampaignId");
            });

            modelBuilder.Entity<UserAccessCampaign>(entity =>
            {
                entity.ToTable("UserAccess_Campaign");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4C2DE6D218");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserApplication");
            });

            modelBuilder.Entity<UsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__UsersInR__AF2760AD31B762FC");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UsersInRoleRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UsersInRoleUser");
            });

            modelBuilder.Entity<Vatorder>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK_VATOrder_1");

                entity.ToTable("VATOrder");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CheckInDate).HasColumnType("datetime");

                entity.Property(e => e.CheckInPerson)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(10);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Vatamount).HasColumnName("VATAmount");

                entity.Property(e => e.VatorderDetail).HasColumnName("VATOrderDetail");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Vatorder)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VATOrder_Brand");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Vatorder)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VATOrder_Provider");
            });

            modelBuilder.Entity<VatorderMapping>(entity =>
            {
                entity.ToTable("VATOrderMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.RentId).HasColumnName("RentID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.VatorderMapping)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VATOrderMapping_VATOrder");
            });

            modelBuilder.Entity<ViewCounter>(entity =>
            {
                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ViewCounter)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ViewCounter_Store");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.Property(e => e.IsUsed).HasColumnName("isUsed");

                entity.Property(e => e.PromotionDetailId).HasColumnName("PromotionDetailID");

                entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

                entity.Property(e => e.VoucherCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.MembershipCard)
                    .WithMany(p => p.Voucher)
                    .HasForeignKey(d => d.MembershipCardId)
                    .HasConstraintName("FK_Voucher_MembershipCard");

                entity.HasOne(d => d.PromotionDetail)
                    .WithMany(p => p.Voucher)
                    .HasForeignKey(d => d.PromotionDetailId)
                    .HasConstraintName("FK_Voucher_PromotionDetail");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Voucher)
                    .HasForeignKey(d => d.PromotionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Voucher_Promotion");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.HasKey(e => e.WardCode);

                entity.Property(e => e.WardName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WardType).HasMaxLength(255);

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.Ward)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ward_District");
            });

            modelBuilder.Entity<WebCustomerFeedback>(entity =>
            {
                entity.Property(e => e.Collection).HasMaxLength(255);

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Fullname).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<WebElement>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.WebElement)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_WebElement_WebElementType");
            });

            modelBuilder.Entity<WebElementType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WebMenu>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLevel).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.WebMenu)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebMenu_WebMenuCategory");

                entity.HasOne(d => d.ParentMenu)
                    .WithMany(p => p.InverseParentMenu)
                    .HasForeignKey(d => d.ParentMenuId)
                    .HasConstraintName("FK_WebMenu_WebMenu");
            });

            modelBuilder.Entity<WebMenuCategory>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.WebMenuCategory)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebMenuCategory_Store");
            });

            modelBuilder.Entity<WebPage>(entity =>
            {
                entity.HasOne(d => d.Store)
                    .WithMany(p => p.WebPage)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_WebPage_Store");
            });
        }
    }
}
