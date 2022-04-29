using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EnterpriseSyncExclude
    {
        public Guid EnterpriseSyncExcludeID { get; set; }
        public int StoreID { get; set; }
        public int TableID { get; set; }
        public int Destination { get; set; }
    }
}
