using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class PagerMessageQueue
    {
        public Guid PagerMessageQueueID { get; set; }
        public Guid PagerID { get; set; }
        public string Message { get; set; } = null!;
        public int RetryCount { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Pager Pager { get; set; } = null!;
    }
}
