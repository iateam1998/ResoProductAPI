using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class UserAccess
    {
        public int Id { get; set; }
        public int? UserAccessCampaignId { get; set; }
    }
}
