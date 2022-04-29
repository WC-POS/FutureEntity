using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class RewardPlan
    {
        public RewardPlan()
        {
            RewardPlanLevels = new HashSet<RewardPlanLevel>();
        }

        public Guid RewardPlanID { get; set; }
        public Guid RegionID { get; set; }
        public int RewardIndex { get; set; }
        public string RewardPlanName { get; set; } = null!;
        public int LevelCount { get; set; }
        public bool NoRewardMessage { get; set; }

        public virtual ICollection<RewardPlanLevel> RewardPlanLevels { get; set; }
    }
}
