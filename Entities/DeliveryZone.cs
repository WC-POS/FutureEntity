using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class DeliveryZone
    {
        public Guid DeliveryZoneID { get; set; }
        public int ZoneIndex { get; set; }
        public Guid RegionID { get; set; }
        public string ZoneName { get; set; } = null!;
        public int Amount { get; set; }
        public int DriverAmount { get; set; }
        public bool IsServiceCharge { get; set; }
    }
}
