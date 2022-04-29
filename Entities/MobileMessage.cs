using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class MobileMessage
    {
        public Guid MobileMessageID { get; set; }
        public string? MessageText { get; set; }
    }
}
