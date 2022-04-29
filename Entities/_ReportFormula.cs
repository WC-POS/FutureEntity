using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportFormula
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte[]? FormulaBytes { get; set; }
        public Guid? ReportID { get; set; }
        public bool? IsActive { get; set; }

        public virtual _Report? Report { get; set; }
    }
}
