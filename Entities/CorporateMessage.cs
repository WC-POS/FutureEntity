using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CorporateMessage
    {
        public Guid CorporateMessageID { get; set; }
        public int State { get; set; }
        public string? Url { get; set; }
        public string ApplicationName { get; set; } = null!;
    }
}
