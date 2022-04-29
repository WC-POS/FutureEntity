using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class BreakJob
    {
        public Guid BreakJobID { get; set; }
        public Guid BreakID { get; set; }
        public int JobCode { get; set; }

        public virtual Break Break { get; set; } = null!;
    }
}
