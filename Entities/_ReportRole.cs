using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _ReportRole
    {
        public Guid ReportRoleID { get; set; }
        public Guid ReportID { get; set; }
        public Guid RoleID { get; set; }
        public byte[]? ReportPermissionBytes { get; set; }
    }
}
