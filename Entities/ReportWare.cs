using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ReportWare
    {
        public Guid ReportWareID { get; set; }
        public int Amount { get; set; }
        public int Index { get; set; }
        public string Item { get; set; } = null!;
        public int StoreID { get; set; }
    }
}
