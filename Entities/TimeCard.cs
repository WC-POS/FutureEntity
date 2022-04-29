using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TimeCard
    {
        public Guid TimeCardID { get; set; }
        public int StoreID { get; set; }
        public short EmpID { get; set; }
        public DateTime CardDate { get; set; }
        public DateTime? RoundedDate { get; set; }
        public short PunchType { get; set; }
        public byte WorkCenter { get; set; }
        public int BreakIndex { get; set; }
        public Guid? ShadowTimeCardForID { get; set; }
        public DateTime? PaycomExportDate { get; set; }
        public bool? IsUpdate { get; set; }
    }
}
