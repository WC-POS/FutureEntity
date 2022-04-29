using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportDataSource
    {
        public Guid ReportDataSourceID { get; set; }
        public string Name { get; set; } = null!;
        public byte[] Reports { get; set; } = null!;
    }
}
