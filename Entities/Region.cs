using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Region
    {
        public Guid RegionID { get; set; }
        public string RegionName { get; set; } = null!;
        public string? RegionDescription { get; set; }
        public string Area { get; set; } = null!;
    }
}
