using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportParameterValue
    {
        public Guid ReportParameterValuesID { get; set; }
        public Guid? ReportID { get; set; }
        public Guid EmployeeID { get; set; }
        public string? ParameterValues { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
