using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MenuUsage
    {
        public Guid MenuUsageID { get; set; }
        public Guid EmployeeID { get; set; }
        public string PageTitle { get; set; } = null!;
        public string RelativePath { get; set; } = null!;
        public int VisitCount { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
