using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class GiftSeriesAvailability
    {
        public Guid GiftSeriesAvailabilityID { get; set; }
        public Guid GiftSeriesID { get; set; }
        public int DayIndex { get; set; }
        public bool IsAvailable { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public virtual GiftSeries GiftSeries { get; set; } = null!;
    }
}
