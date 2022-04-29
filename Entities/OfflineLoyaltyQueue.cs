using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class OfflineLoyaltyQueue
    {
        public Guid OfflineLoyaltyQueueID { get; set; }
        public Guid SaleID { get; set; }
        public int TransactionType { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
