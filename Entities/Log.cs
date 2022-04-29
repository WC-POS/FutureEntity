using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Log
    {
        public Guid LogID { get; set; }
        public DateTime LogDate { get; set; }
        public int ErrorType { get; set; }
        public int LogLevel { get; set; }
        public int TerminalNumber { get; set; }
        public bool IsEncrypted { get; set; }
        public int ProcessGroup { get; set; }
        public string Application { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
