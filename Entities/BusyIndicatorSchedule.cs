using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class BusyIndicatorSchedule
    {
        public Guid BusyIndicatorScheduleID { get; set; }
        public Guid BusyIndicatorID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TerminalNumber { get; set; }
    }
}
