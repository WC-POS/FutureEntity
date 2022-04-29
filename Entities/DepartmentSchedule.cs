using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DepartmentSchedule
    {
        public Guid DepartmentScheduleID { get; set; }
        public Guid DepartmentID { get; set; }
        public int DayIndex { get; set; }
        public bool IsUsed { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}
