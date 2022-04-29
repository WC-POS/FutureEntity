using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class GrandTotal
    {
        public Guid GrandTotalID { get; set; }
        public long Total { get; set; }
        public DateTime LastUpdate { get; set; }
        public short TerminalNumber { get; set; }
    }
}
