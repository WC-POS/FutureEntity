using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TaxSchedule
    {
        public Guid TaxScheduleID { get; set; }
        public Guid TaxID { get; set; }
        public int DayIndex { get; set; }
        public bool UseTax { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public virtual Tax Tax { get; set; } = null!;
    }
}
