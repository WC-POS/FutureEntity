using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Break
    {
        public Break()
        {
            BreakJobs = new HashSet<BreakJob>();
        }

        public Guid BreakID { get; set; }
        public Guid RegionID { get; set; }
        public int BreakIndex { get; set; }
        public string BreakName { get; set; } = null!;
        public bool IsPaid { get; set; }
        public int MinutesAllowed { get; set; }
        public int MinutesToQualify { get; set; }
        public bool PunchIn { get; set; }
        public bool TrackEndBreak { get; set; }

        public virtual ICollection<BreakJob> BreakJobs { get; set; }
    }
}
