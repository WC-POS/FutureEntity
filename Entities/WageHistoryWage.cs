using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class WageHistoryWage
    {
        public Guid WageHistoryWageID { get; set; }
        public Guid WageHistoryID { get; set; }
        public int WageHistoryWageIndex { get; set; }
        public int OldWorkCenter { get; set; }
        public int OldOvertimeRate { get; set; }
        public int OldRegularRate { get; set; }
        public int NewWorkCenter { get; set; }
        public int NewOvertimeRate { get; set; }
        public int NewRegularRate { get; set; }

        public virtual WageHistory WageHistory { get; set; } = null!;
    }
}
