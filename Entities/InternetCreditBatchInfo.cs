using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class InternetCreditBatchInfo
    {
        public Guid InternetCreditBatchInfoID { get; set; }
        public int CurrentBatchNumber { get; set; }
        public int CurrentBatchItemNumber { get; set; }
        public long CurrentGiftCardNumber { get; set; }
    }
}
