using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vSalesByDateAndTime
    {
        public DateTime? SaleHour { get; set; }
        public int Total { get; set; }
        public int SubTotal { get; set; }
        public int SaleCount { get; set; }
        public int CustomerCount { get; set; }
        public int ItemCount { get; set; }
        public int TaxTotal { get; set; }
        public int CCHouseTips { get; set; }
        public int CCTotal { get; set; }
        public int CCEmpTips { get; set; }
        public int DiscountTotal { get; set; }
        public int CouponTotal { get; set; }
        public int GiftUsedTotal { get; set; }
        public int MediaTotal { get; set; }
        public int MediaCount { get; set; }
        public int TenderTotal { get; set; }
    }
}
