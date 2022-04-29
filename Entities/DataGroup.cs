using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DataGroup
    {
        public DataGroup()
        {
            DataGroupStores = new HashSet<DataGroupStore>();
        }

        public Guid DataGroupID { get; set; }
        public Guid ScheduleGroupID { get; set; }
        public DateTime? AppliedDate { get; set; }

        public virtual ScheduledUpdateScheduleGroup ScheduleGroup { get; set; } = null!;
        public virtual ICollection<DataGroupStore> DataGroupStores { get; set; }
    }
}
