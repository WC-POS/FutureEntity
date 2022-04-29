using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ItemSize
    {
        public Guid ItemSizeID { get; set; }
        public Guid RegionID { get; set; }
        public string Description { get; set; } = null!;
        public string ItemDescriptionPrefix { get; set; } = null!;
        public string ReceiptDescriptionPrefix { get; set; } = null!;
    }
}
