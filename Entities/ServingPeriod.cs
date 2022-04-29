using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ServingPeriod
    {
        public Guid ServingPeriodID { get; set; }
        public string Description { get; set; } = null!;
        public DateTime EndTime { get; set; }
        public int Index { get; set; }
        public DateTime StartTime { get; set; }
        public int StoreID { get; set; }
    }
}
