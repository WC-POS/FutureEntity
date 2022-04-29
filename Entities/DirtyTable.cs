using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DirtyTable
    {
        public Guid DirtyTableID { get; set; }
        public int StoreID { get; set; }
        public short TableNumber { get; set; }
    }
}
