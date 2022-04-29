using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class StatusMessage
    {
        public Guid StatusMessageID { get; set; }
        public int StoreID { get; set; }
        public int TerminalID { get; set; }
        public byte StatusType { get; set; }
        public byte SubStatusType { get; set; }
        public int DeviceID { get; set; }
        public string DeviceName { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime LastUpdated { get; set; }
    }
}
