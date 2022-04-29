using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class AdScheduleGroup
    {
        public Guid GroupID { get; set; }
        public Guid DisplayID { get; set; }
        public Guid ObjectID { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsEnabled { get; set; }
        public int Type { get; set; }
        public int Priority { get; set; }
        public bool? ByRange { get; set; }
    }
}
