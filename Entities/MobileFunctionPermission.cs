using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MobileFunctionPermission
    {
        public Guid PermissionID { get; set; }
        public string FunctionName { get; set; } = null!;
        public bool? AskForSupervisorID { get; set; }
        public int? MinimumSecurityLevel { get; set; }
        public int? TerminalNumber { get; set; }
    }
}
