using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class BeverageCountItem
    {
        public Guid BeverageCountItemID { get; set; }
        public Guid BeverageCountID { get; set; }
        public string ItemName { get; set; } = null!;
        public int InCount { get; set; }
        public int OutCount { get; set; }

        public virtual BeverageCount BeverageCount { get; set; } = null!;
    }
}
