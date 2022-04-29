using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class LaborRule
    {
        public Guid LaborRuleID { get; set; }
        public Guid LaborRuleSetID { get; set; }
        public int DayThreshold { get; set; }
        public int HourThreshold { get; set; }
        public int HourThresholdType { get; set; }
        public decimal Modifier { get; set; }
        public decimal RateCutoff { get; set; }
        public bool UseDayThreshold { get; set; }
        public bool UseRateCutoff { get; set; }

        public virtual LaborRuleSet LaborRuleSet { get; set; } = null!;
    }
}
