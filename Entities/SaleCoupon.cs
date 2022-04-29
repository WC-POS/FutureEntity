using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleCoupon
    {
        public Guid SaleCouponID { get; set; }
        public Guid SaleID { get; set; }
        public int CouponIndex { get; set; }
        public int Dollar { get; set; }
        public int AppliedCount { get; set; }
        public int ActualAppliedCount { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
