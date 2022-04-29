using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportCategory
    {
        public _ReportCategory()
        {
            _Reports = new HashSet<_Report>();
        }

        public Guid ReportCategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public int SortPriority { get; set; }

        public virtual ICollection<_Report> _Reports { get; set; }
    }
}
