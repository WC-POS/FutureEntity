using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class EmployeeDrawer
    {
        public Guid EmployeeDrawerID { get; set; }
        public Guid EmployeeID { get; set; }
        public int DrawerIndex { get; set; }
        public short TerminalNumber { get; set; }
        public short DrawerNumber { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
