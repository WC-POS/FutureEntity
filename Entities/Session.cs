using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Session
    {
        public Guid SessionID { get; set; }
        public DateTime sessionDate { get; set; }
        public string sessionKey { get; set; } = null!;
        public DateTime lastActivityDate { get; set; }
    }
}
