using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TimedMenu
    {
        public TimedMenu()
        {
            TimedMenuDays = new HashSet<TimedMenuDay>();
            TimedMenuJobs = new HashSet<TimedMenuJob>();
        }

        public Guid TimedMenuID { get; set; }
        public string Description { get; set; } = null!;
        public int StoreID { get; set; }
        public int TerminalType { get; set; }

        public virtual ICollection<TimedMenuDay> TimedMenuDays { get; set; }
        public virtual ICollection<TimedMenuJob> TimedMenuJobs { get; set; }
    }
}
