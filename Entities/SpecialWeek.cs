using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SpecialWeek
    {
        public Guid SpecialWeekID { get; set; }
        public Guid SpecialID { get; set; }
        public int SpecialWeekIndex { get; set; }
        public string ItemName { get; set; } = null!;
        public bool ShowCountAvailable { get; set; }
        public int Price { get; set; }

        public virtual Special Special { get; set; } = null!;
    }
}
