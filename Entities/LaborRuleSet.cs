using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class LaborRuleSet
    {
        public LaborRuleSet()
        {
            LaborRules = new HashSet<LaborRule>();
        }

        public Guid LaborRuleSetID { get; set; }
        public Guid LaborRuleGroupID { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool UseRollingWorkday { get; set; }

        public virtual ICollection<LaborRule> LaborRules { get; set; }
    }
}
