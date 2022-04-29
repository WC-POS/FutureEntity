using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Cashier
    {
        public Guid CashierID { get; set; }
        public int StoreID { get; set; }
        public int CashierIndex { get; set; }
        public string Cashier1 { get; set; } = null!;
    }
}
