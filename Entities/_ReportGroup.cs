using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportGroup
    {
        public _ReportGroup()
        {
            _ReportGroupLayouts = new HashSet<_ReportGroupLayout>();
        }

        public Guid ReportGroupID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid CategoryID { get; set; }
        public int ParamLinkage { get; set; }

        public virtual ICollection<_ReportGroupLayout> _ReportGroupLayouts { get; set; }
    }
}
