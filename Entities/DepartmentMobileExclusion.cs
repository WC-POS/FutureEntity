using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DepartmentMobileExclusion
    {
        public Guid DepartmentMobileExclusionID { get; set; }
        public Guid DepartmentID { get; set; }
        public short EmpID { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}
