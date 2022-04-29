using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DinePointServingPeriod
    {
        public int PeriodIndex { get; set; }
        public int StoreID { get; set; }
        public string? PeriodName { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
    }
}
