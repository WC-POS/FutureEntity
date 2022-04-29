using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class SyncDatum
    {
        public Guid SyncDataID { get; set; }
        public Guid SyncID { get; set; }
        public Guid DBRecordID { get; set; }

        public virtual Sync Sync { get; set; } = null!;
    }
}
