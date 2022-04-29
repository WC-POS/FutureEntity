using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EmployeeRate
    {
        public Guid EmployeeRateID { get; set; }
        public Guid EmployeeID { get; set; }
        public int RateIndex { get; set; }
        public int WorkCenter { get; set; }
        public int OvertimeRate { get; set; }
        public int RegularRate { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
