using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Schedule
    {
        public Schedule()
        {
            ScheduleItems = new HashSet<ScheduleItem>();
        }

        public Guid ScheduleID { get; set; }
        public int StoreID { get; set; }
        public DateTime ScheduleDate { get; set; }
        public int ScheduleCount { get; set; }

        public virtual ICollection<ScheduleItem> ScheduleItems { get; set; }
    }
}
