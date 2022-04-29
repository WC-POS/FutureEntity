using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ResourceLanguage
    {
        public Guid ResourceLanguageID { get; set; }
        public int StoreID { get; set; }
        public int Language { get; set; }
        public int ResourceKey { get; set; }
        public string Value { get; set; } = null!;
    }
}
