using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScheduledUpdateScheduleGroup
    {
        public ScheduledUpdateScheduleGroup()
        {
            DataGroups = new HashSet<DataGroup>();
            ScheduledUpdateScheduleGroupUpdates = new HashSet<ScheduledUpdateScheduleGroupUpdate>();
        }

        public Guid ScheduleGroupID { get; set; }
        public string? ScheduleGroupName { get; set; }
        public DateTime ScheduleGroupDate { get; set; }
        public Guid? DataGroupID { get; set; }

        public virtual ICollection<DataGroup> DataGroups { get; set; }
        public virtual ICollection<ScheduledUpdateScheduleGroupUpdate> ScheduledUpdateScheduleGroupUpdates { get; set; }
    }
}
