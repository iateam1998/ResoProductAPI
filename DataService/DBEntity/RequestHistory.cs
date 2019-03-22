using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class RequestHistory
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int BrandId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? RequestTime { get; set; }
        public string RequestData { get; set; }
        public string RequestToken { get; set; }
        public string RequestType { get; set; }
        public string RequestUri { get; set; }
        public string ControllerName { get; set; }
        public int? StatusCode { get; set; }
        public bool? Success { get; set; }
        public string Message { get; set; }
        public string ResponseData { get; set; }
    }
}
