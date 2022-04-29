using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class GiftUsed
    {
        public Guid GiftUsedID { get; set; }
        public Guid GiftID { get; set; }
        public int UseIndex { get; set; }
        public int CheckNumber { get; set; }
        public int Amount { get; set; }

        public virtual Gift Gift { get; set; } = null!;
    }
}
