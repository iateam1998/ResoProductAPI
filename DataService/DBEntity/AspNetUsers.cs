using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            DeliveryInformation = new HashSet<DeliveryInformation>();
            Rating = new HashSet<Rating>();
            Receipt = new HashSet<Receipt>();
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public int? AdminStoreId { get; set; }
        public int? BrandId { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Store AdminStore { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<DeliveryInformation> DeliveryInformation { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}
