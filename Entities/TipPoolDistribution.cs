using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TipPoolDistribution
    {
        public Guid TipPoolDistributionID { get; set; }
        public Guid TipPoolID { get; set; }
        public byte JobCode { get; set; }
        public byte DistributionType { get; set; }
        public short Percentage { get; set; }

        public virtual TipPool TipPool { get; set; } = null!;
    }
}
