using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemMobileExclusion
    {
        public Guid ItemMobileExclusionID { get; set; }
        public Guid ItemID { get; set; }
        public short EmpID { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
