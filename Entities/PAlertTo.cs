using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PAlertTo
    {
        public Guid AlertEmpID { get; set; }
        public Guid AlertID { get; set; }
        public int ToType { get; set; }
        public int EmpID { get; set; }
        public int ClassIndex { get; set; }

        public virtual PAlert Alert { get; set; } = null!;
    }
}
