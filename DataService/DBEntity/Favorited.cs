using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Favorited
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public bool Active { get; set; }
        public bool? FavoriteStt { get; set; }

        public virtual Product Product { get; set; }
    }
}
