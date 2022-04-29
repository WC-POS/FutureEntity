using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DiscountTranslation
    {
        public Guid DiscountTranslationID { get; set; }
        public Guid DiscountID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Discount Discount { get; set; } = null!;
    }
}
