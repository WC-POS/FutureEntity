using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemTranslation
    {
        public Guid ItemTranslationID { get; set; }
        public Guid ItemID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Item Item { get; set; } = null!;
    }
}
