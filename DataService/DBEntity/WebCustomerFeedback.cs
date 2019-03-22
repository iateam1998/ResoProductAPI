using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class WebCustomerFeedback
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Title { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Content { get; set; }
        public bool Active { get; set; }
        public string Collection { get; set; }
        public string CustomFields { get; set; }
    }
}
