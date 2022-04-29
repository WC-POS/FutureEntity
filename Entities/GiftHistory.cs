using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class GiftHistory
    {
        public Guid GiftHistoryID { get; set; }
        public Guid GiftID { get; set; }
        public int HistoryIndex { get; set; }
        public int Type { get; set; }
        public int CheckNumber { get; set; }
        public int Amount { get; set; }
        public DateTime HistoryDate { get; set; }

        public virtual Gift Gift { get; set; } = null!;
    }
}
