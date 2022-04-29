using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class _BackgroundProcessLock
    {
        public Guid BackgroundProcessLockId { get; set; }
        public string BackgroundProcessName { get; set; } = null!;
        public bool Locked { get; set; }
        public string? LockingApplication { get; set; }
    }
}
