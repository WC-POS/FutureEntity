using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleGiftSold
    {
        public Guid SaleGiftSoldID { get; set; }
        public Guid SaleID { get; set; }
        public int GiftSoldIndex { get; set; }
        public byte IsTracked { get; set; }
        public int SeriesIndex { get; set; }
        public string? GiftNumber { get; set; }
        public int Amount { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
