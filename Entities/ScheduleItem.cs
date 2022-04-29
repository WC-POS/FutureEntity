using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScheduleItem
    {
        public Guid ScheduleItemID { get; set; }
        public Guid ScheduleID { get; set; }
        public int ScheduleItemIndex { get; set; }
        public byte WorkCenter { get; set; }
        public byte Shift { get; set; }
        public int EmpID { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string? ShiftDescription { get; set; }

        public virtual Schedule Schedule { get; set; } = null!;
    }
}
