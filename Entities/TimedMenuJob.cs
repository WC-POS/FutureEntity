using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TimedMenuJob
    {
        public Guid TimedMenuJobID { get; set; }
        public Guid TimedMenuID { get; set; }
        public int JobCode { get; set; }

        public virtual TimedMenu TimedMenu { get; set; } = null!;
    }
}
