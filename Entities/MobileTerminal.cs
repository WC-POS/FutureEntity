using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MobileTerminal
    {
        public MobileTerminal()
        {
            MobileTerminalSessionInfos = new HashSet<MobileTerminalSessionInfo>();
        }

        public Guid MobileTerminalID { get; set; }
        public string MobileIdentifier { get; set; } = null!;
        public short? EmpID { get; set; }
        public int DeviceStatus { get; set; }
        public int? TerminalNumber { get; set; }
        public string? SyncFile { get; set; }
        public string? Description { get; set; }
        public int? SyncID { get; set; }
        public string LastKnownIP { get; set; } = null!;

        public virtual ICollection<MobileTerminalSessionInfo> MobileTerminalSessionInfos { get; set; }
    }
}
