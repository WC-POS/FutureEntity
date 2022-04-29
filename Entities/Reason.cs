using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Reason
    {
        public Guid ReasonID { get; set; }
        public Guid RegionID { get; set; }
        public int ReasonType { get; set; }
        public int ReasonIndex { get; set; }
        public string ReasonName { get; set; } = null!;
    }
}
