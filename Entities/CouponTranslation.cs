using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CouponTranslation
    {
        public Guid CouponTranslationID { get; set; }
        public Guid CouponID { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Coupon Coupon { get; set; } = null!;
    }
}
