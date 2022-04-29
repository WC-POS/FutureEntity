using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TabbedOutAlert
    {
        public Guid MessageID { get; set; }
        public string TabOutCode { get; set; } = null!;
        public string Message { get; set; } = null!;
        public bool WasViewed { get; set; }
    }
}
