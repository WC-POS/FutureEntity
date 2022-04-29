using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScheduledUpdateMaintenance
    {
        public ScheduledUpdateMaintenance()
        {
            ScheduledUpdateScheduleGroupUpdates = new HashSet<ScheduledUpdateScheduleGroupUpdate>();
        }

        public Guid ScheduledUpdateMaintenanceID { get; set; }
        public string Maintenance { get; set; } = null!;
        public string PrimaryTable { get; set; } = null!;
        public Guid? MenuPageItemID { get; set; }

        public virtual ICollection<ScheduledUpdateScheduleGroupUpdate> ScheduledUpdateScheduleGroupUpdates { get; set; }
    }
}
