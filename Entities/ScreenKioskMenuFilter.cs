using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenKioskMenuFilter
    {
        public Guid ScreenKioskMenuFilterID { get; set; }
        public Guid ScreenKioskMenuID { get; set; }
        public int ScreenKioskMenuFilterIndex { get; set; }
        public short Type { get; set; }
        public string? Filter { get; set; }
        public string? FilterEnd { get; set; }
        public string? DepartmentNameFilter { get; set; }
        public string? DepartmentGroupFilter { get; set; }
        public string? ItemNameFilter { get; set; }
        public string? ItemUPCFilter { get; set; }

        public virtual ScreenKioskMenu ScreenKioskMenu { get; set; } = null!;
    }
}
