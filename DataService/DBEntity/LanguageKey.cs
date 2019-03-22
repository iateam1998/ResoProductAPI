using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class LanguageKey
    {
        public LanguageKey()
        {
            LanguageValue = new HashSet<LanguageValue>();
        }

        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<LanguageValue> LanguageValue { get; set; }
    }
}
