using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportParameter
    {
        public Guid ReportParameterID { get; set; }
        public string? ParameterName { get; set; }
        public byte[]? ParameterBytes { get; set; }
        public Guid? ReportID { get; set; }
        public bool? IsActive { get; set; }

        public virtual _Report? Report { get; set; }
    }
}
