using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DataTypeReference
    {
        public DataTypeReference()
        {
            ScheduledUpdateScheduleGroupUpdateSettingChanges = new HashSet<ScheduledUpdateScheduleGroupUpdateSettingChange>();
        }

        public int DataTypeID { get; set; }
        public string DataType { get; set; } = null!;
        public string SqlDataType { get; set; } = null!;

        public virtual ICollection<ScheduledUpdateScheduleGroupUpdateSettingChange> ScheduledUpdateScheduleGroupUpdateSettingChanges { get; set; }
    }
}
