using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SkinSchedule
    {
        public Guid SkinScheduleID { get; set; }
        public Guid SkinID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TerminalNumber { get; set; }
    }
}
