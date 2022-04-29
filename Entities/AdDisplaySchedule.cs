using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class AdDisplaySchedule
    {
        public Guid DisplayScheduleID { get; set; }
        public Guid DisplayID { get; set; }
        public Guid ObjectID { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsEnabled { get; set; }
        public int Priority { get; set; }
        public int Type { get; set; }
        public Guid GroupID { get; set; }
    }
}
