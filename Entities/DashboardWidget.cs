using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DashboardWidget
    {
        public Guid DashboardWidgetID { get; set; }
        public string Name { get; set; } = null!;
        public int WidgetType { get; set; }
        public int SortOrder { get; set; }
        public byte[]? SettingsBytes { get; set; }
        public Guid EmployeeID { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
