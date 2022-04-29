using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MobileTerminalTransaction
    {
        public Guid MobileTerminalTransactionID { get; set; }
        public Guid TransactionID { get; set; }
        public byte[] SessionID { get; set; } = null!;
        public byte State { get; set; }
        public byte[] Response { get; set; } = null!;
        public int TerminalNumber { get; set; }
    }
}
