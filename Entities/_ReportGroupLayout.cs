using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportGroupLayout
    {
        public Guid ReportGroupLayoutID { get; set; }
        public Guid ReportGroupID { get; set; }
        public Guid ReportID { get; set; }
        public Guid LayoutID { get; set; }
        public int ReportLayoutIndex { get; set; }
        public int GroupLayoutIndex { get; set; }
        public string? ReportName { get; set; }
        public string? LayoutName { get; set; }

        public virtual _ReportGroup ReportGroup { get; set; } = null!;
    }
}
