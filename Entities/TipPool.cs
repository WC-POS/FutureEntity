using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class TipPool
    {
        public TipPool()
        {
            TipPoolContributions = new HashSet<TipPoolContribution>();
            TipPoolDistributions = new HashSet<TipPoolDistribution>();
        }

        public Guid TipPoolID { get; set; }
        public string? TipPoolName { get; set; }
        public short? StartTimeInMinutes { get; set; }
        public short? EndTimeInMinutes { get; set; }
        public byte? OverrideDistributionType { get; set; }
        public byte Days { get; set; }

        public virtual ICollection<TipPoolContribution> TipPoolContributions { get; set; }
        public virtual ICollection<TipPoolDistribution> TipPoolDistributions { get; set; }
    }
}
