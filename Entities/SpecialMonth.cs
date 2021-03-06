using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SpecialMonth
    {
        public Guid SpecialMonthID { get; set; }
        public Guid SpecialID { get; set; }
        public int SpecialMonthIndex { get; set; }
        public string ItemName { get; set; } = null!;
        public bool ShowCountAvailable { get; set; }
        public int Price { get; set; }

        public virtual Special Special { get; set; } = null!;
    }
}
