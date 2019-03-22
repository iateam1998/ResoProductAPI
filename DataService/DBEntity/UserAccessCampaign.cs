using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class UserAccessCampaign
    {
        public int Id { get; set; }
        public int UserAccessId { get; set; }
        public int CampaignId { get; set; }
    }
}
