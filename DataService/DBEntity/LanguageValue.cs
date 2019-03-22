using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class LanguageValue
    {
        public int Id { get; set; }
        public int LanguageKeyId { get; set; }
        public int LanguageId { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }

        public virtual Language Language { get; set; }
        public virtual LanguageKey LanguageKey { get; set; }
    }
}
