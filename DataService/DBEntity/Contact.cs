using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Gender { get; set; }
        public string Email { get; set; }
        public string ProfileUrl { get; set; }
        public DateTime? Birthday { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Active { get; set; }
        public string Username { get; set; }
        public int? BrandId { get; set; }
        public string Address { get; set; }
        public string Organization { get; set; }
        public string Job { get; set; }
        public string Position { get; set; }
        public int? FirstLocationId { get; set; }
        public string Fax { get; set; }
        public int? TotalVisted { get; set; }
        public int? TypeContactFrom { get; set; }
        public DateTime? LastVisted { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
