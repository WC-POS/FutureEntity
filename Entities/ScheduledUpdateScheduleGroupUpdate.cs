using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScheduledUpdateScheduleGroupUpdate
    {
        public ScheduledUpdateScheduleGroupUpdate()
        {
            ScheduledUpdateScheduleGroupUpdateSettingChanges = new HashSet<ScheduledUpdateScheduleGroupUpdateSettingChange>();
        }

        public Guid ScheduledUpdateUpdateID { get; set; }
        public Guid ScheduledUpdateMaintenanceID { get; set; }
        public Guid ScheduleGroupID { get; set; }

        public virtual ScheduledUpdateScheduleGroup ScheduleGroup { get; set; } = null!;
        public virtual ScheduledUpdateMaintenance ScheduledUpdateMaintenance { get; set; } = null!;
        public virtual ICollection<ScheduledUpdateScheduleGroupUpdateSettingChange> ScheduledUpdateScheduleGroupUpdateSettingChanges { get; set; }
    }
}
