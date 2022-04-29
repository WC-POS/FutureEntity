using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleItemCoupon
    {
        public Guid SaleItemCouponID { get; set; }
        public Guid SaleItemID { get; set; }
        public int ItemIndex { get; set; }
        public int CouponIndex { get; set; }
        public int Amount { get; set; }
        public int SplitAmount { get; set; }

        public virtual SaleItem SaleItem { get; set; } = null!;
    }
}
