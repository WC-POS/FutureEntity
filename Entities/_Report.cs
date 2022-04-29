using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _Report
    {
        public _Report()
        {
            _ReportFormulas = new HashSet<_ReportFormula>();
            _ReportParameters = new HashSet<_ReportParameter>();
        }

        public Guid ReportID { get; set; }
        public string? ReportName { get; set; }
        public string? Description { get; set; }
        public Guid ReportCategoryID { get; set; }
        public byte[]? LayoutBytes { get; set; }
        public byte[]? DefinitionBytes { get; set; }
        public DateTime LastEdited { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public byte[]? MajorGroupBytes { get; set; }

        public virtual _ReportCategory ReportCategory { get; set; } = null!;
        public virtual ICollection<_ReportFormula> _ReportFormulas { get; set; }
        public virtual ICollection<_ReportParameter> _ReportParameters { get; set; }
    }
}
