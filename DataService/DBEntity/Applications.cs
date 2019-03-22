using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Applications
    {
        public Applications()
        {
            Roles = new HashSet<Roles>();
            Users = new HashSet<Users>();
        }

        public string ApplicationName { get; set; }
        public Guid ApplicationId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
