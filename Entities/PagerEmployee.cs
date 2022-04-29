using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PagerEmployee
    {
        public Guid PagerEmployeeID { get; set; }
        public Guid PagerID { get; set; }
        public short EmployeeID { get; set; }

        public virtual Pager Pager { get; set; } = null!;
    }
}
