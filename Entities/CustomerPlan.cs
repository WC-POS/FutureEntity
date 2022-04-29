using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CustomerPlan
    {
        public Guid CustomerPlanID { get; set; }
        public Guid CustomerID { get; set; }
        public int PlanIndex { get; set; }
        public int CurrentAmount { get; set; }
        public byte CurrentLevel { get; set; }
        public byte RepeatCount { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
