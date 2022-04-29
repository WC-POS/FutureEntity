using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Tare
    {
        public Guid TareID { get; set; }
        public string Description { get; set; } = null!;
        public int Index { get; set; }
        public int StoreID { get; set; }
        public int Weight { get; set; }
    }
}
