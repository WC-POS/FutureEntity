using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Special
    {
        public Special()
        {
            SpecialMonths = new HashSet<SpecialMonth>();
            SpecialWeeks = new HashSet<SpecialWeek>();
        }

        public Guid SpecialID { get; set; }
        public Guid RegionID { get; set; }
        public int SpecialIndex { get; set; }
        public string? SpecialName { get; set; }
        public short SpecialType { get; set; }

        public virtual ICollection<SpecialMonth> SpecialMonths { get; set; }
        public virtual ICollection<SpecialWeek> SpecialWeeks { get; set; }
    }
}
