using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TipPoolContribution
    {
        public Guid TipPoolContributionID { get; set; }
        public Guid TipPoolID { get; set; }
        public byte JobCode { get; set; }
        public string? Name { get; set; }
        public byte ContributionType { get; set; }
        public short Percentage { get; set; }

        public virtual TipPool TipPool { get; set; } = null!;
    }
}
