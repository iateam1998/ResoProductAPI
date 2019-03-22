using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PersonId { get; set; }
        public int? BirthYear { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool? Sex { get; set; }
        public int? RentId { get; set; }
        public int? RentGroup { get; set; }
        public string Note { get; set; }

        public virtual OrderGroup RentGroupNavigation { get; set; }
    }
}
