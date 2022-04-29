using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScheduledUpdateScheduleGroupUpdateSettingChange
    {
        public Guid ScheduledUpdateSettingChangeID { get; set; }
        public Guid ScheduledUpdateUpdateID { get; set; }
        public string ObjectName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string ColumnName { get; set; } = null!;
        public string OriginalFieldID { get; set; } = null!;
        public string PreviousValue { get; set; } = null!;
        public string NewValue { get; set; } = null!;
        public int DataTypeID { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime LastModified { get; set; }

        public virtual DataTypeReference DataType { get; set; } = null!;
        public virtual ScheduledUpdateScheduleGroupUpdate ScheduledUpdateUpdate { get; set; } = null!;
    }
}
