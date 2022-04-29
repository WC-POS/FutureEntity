using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CustomerLastOrder
    {
        public Guid CustomerOrderID { get; set; }
        public Guid? CustomerID { get; set; }
        public int OrderIndex { get; set; }
        public DateTime? OrderDate { get; set; }
        public int CheckNumber { get; set; }
        public DateTime? SettleDate { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
