using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class JobCode
    {
        public JobCode()
        {
            JobCodeDeptMasks = new HashSet<JobCodeDeptMask>();
        }

        public Guid JobCodeID { get; set; }
        public string Description { get; set; } = null!;
        public bool GetSharedTip { get; set; }
        public bool GiveSharedTip { get; set; }
        public int Index { get; set; }
        public bool IsDeliveryDriver { get; set; }
        public string LaborGroup { get; set; } = null!;
        public bool NoPromptForSeatOnModifier { get; set; }
        public bool PromptForSeat { get; set; }
        public int RevenueCenter { get; set; }
        public int Section { get; set; }
        public int StoreID { get; set; }
        public int TipGetMethod { get; set; }
        public int TipGiveIsMandatory { get; set; }
        public int TipPercentageReceived { get; set; }

        public virtual ICollection<JobCodeDeptMask> JobCodeDeptMasks { get; set; }
    }
}
