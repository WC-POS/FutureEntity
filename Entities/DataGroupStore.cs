using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DataGroupStore
    {
        public Guid DataGroupStoreID { get; set; }
        public Guid DataGroupID { get; set; }
        public int StoreID { get; set; }

        public virtual DataGroup DataGroup { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
