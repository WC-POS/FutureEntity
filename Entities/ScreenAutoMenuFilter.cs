﻿using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class ScreenAutoMenuFilter
    {
        public ScreenAutoMenuFilter()
        {
            ScreenAutoMenuFilterButtonSettings = new HashSet<ScreenAutoMenuFilterButtonSetting>();
        }

        public Guid ScreenAutoMenuFilterID { get; set; }
        public Guid ScreenAutoMenuID { get; set; }
        public byte Priority { get; set; }
        public string? DepartmentNameFilter { get; set; }
        public string? DepartmentGroupFilter { get; set; }
        public string? ItemNameFilter { get; set; }
        public string? ItemUPCFilter { get; set; }
        public string? MenuFilter { get; set; }
        public bool? ExcludeModifiers { get; set; }
        public bool SortDirection { get; set; }
        public string? FilterMax { get; set; }
        public bool? ShowAvailability { get; set; }
        public bool? ProcessItemBuffer { get; set; }
        public bool? ReplaceItemBuffer { get; set; }
        public int Priority2 { get; set; }

        public virtual ScreenAutoMenu ScreenAutoMenu { get; set; } = null!;
        public virtual ICollection<ScreenAutoMenuFilterButtonSetting> ScreenAutoMenuFilterButtonSettings { get; set; }
    }
}
