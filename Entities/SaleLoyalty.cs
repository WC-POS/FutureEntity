using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleLoyalty
    {
        public Guid SaleLoyaltyID { get; set; }
        public Guid SaleID { get; set; }
        public int LoyaltyIndex { get; set; }
        public int CurrentCredits { get; set; }
        public string? Rating { get; set; }
        public string CouponCode { get; set; } = null!;
        public int Credits { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
