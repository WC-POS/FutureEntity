using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportTempDatum
    {
        public Guid TempStateID { get; set; }
        public Guid PermanentID { get; set; }
        public byte[]? ObjectStateBytes { get; set; }
        public DateTime CreateStamp { get; set; }
    }
}
