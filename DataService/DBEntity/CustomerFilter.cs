using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class CustomerFilter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? StoreId { get; set; }
        public int? CusTypeId { get; set; }
        public int? AgeFrom { get; set; }
        public int? AgeTo { get; set; }
        public int? BirthdayMonth { get; set; }
        public DateTime? BirthdayFrom { get; set; }
        public DateTime? BirthdayTo { get; set; }
        public int? BirthdayOption { get; set; }
        public bool? Gender { get; set; }
        public int? VisitedTimesFrom { get; set; }
        public int? VisitedTimesTo { get; set; }
        public bool? IsEnableCusType { get; set; }
        public bool? IsEnableAge { get; set; }
        public bool? IsEnableBirthday { get; set; }
        public bool? IsEnableGender { get; set; }
        public bool? IsEnableVisitedTimes { get; set; }
        public bool Active { get; set; }
        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
