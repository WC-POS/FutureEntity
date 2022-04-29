using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CouponItem
    {
        public Guid CouponItemID { get; set; }
        public Guid CouponID { get; set; }
        public int CouponItemIndex { get; set; }
        public string? ItemName { get; set; }
        public bool IsRequired { get; set; }
        public int Price { get; set; }

        public virtual Coupon Coupon { get; set; } = null!;
    }
}
