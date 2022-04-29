using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TempState
    {
        public Guid TempStateID { get; set; }
        public Guid PermanentID { get; set; }
        public byte[]? ObjectState { get; set; }
        public DateTime CreateStamp { get; set; }
    }
}
