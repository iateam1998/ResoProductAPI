using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class TaskDetail
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? Status { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreatedBy { get; set; }
        public bool Active { get; set; }
        public int StoreId { get; set; }
        public TimeSpan? Duration { get; set; }
        public int? EmployeeId { get; set; }
        public string ApprovedBy { get; set; }
    }
}
