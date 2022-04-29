using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SaleShare
    {
        public Guid SaleShareID { get; set; }
        public Guid SaleID { get; set; }
        public int ShareIndex { get; set; }
        public int EmpID { get; set; }
        public int SalePercent { get; set; }
        public int TipPercent { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
