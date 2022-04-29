using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class WageHistory
    {
        public WageHistory()
        {
            WageHistoryWages = new HashSet<WageHistoryWage>();
        }

        public Guid WageHistoryID { get; set; }
        public int StoreID { get; set; }
        public int EmpID { get; set; }
        public DateTime WageDate { get; set; }

        public virtual ICollection<WageHistoryWage> WageHistoryWages { get; set; }
    }
}
