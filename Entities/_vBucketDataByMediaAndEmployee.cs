using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _vBucketDataByMediaAndEmployee
    {
        public decimal TenderTotal { get; set; }
        public decimal Tips { get; set; }
        public decimal DeclaredTipsDirect { get; set; }
        public decimal DeclaredTipsIndirect { get; set; }
        public decimal TenderTotalWithTips { get; set; }
        public DateTime? BucketDate { get; set; }
        public int? HourOfDay { get; set; }
        public int? MediaIndex { get; set; }
        public int? EmpID { get; set; }
        public int StoreID { get; set; }
        public string? ServingPeriod { get; set; }
        public DateTime? LastUpdated { get; set; }
        public bool? Dirty { get; set; }
    }
}
