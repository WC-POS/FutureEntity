using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class GlobalCashier
    {
        public Guid GlobalCashierID { get; set; }
        public int GroupIndex { get; set; }
        public DateTime ChangeDate { get; set; }
        public int LastCashier { get; set; }
        public int StoreID { get; set; }
    }
}
