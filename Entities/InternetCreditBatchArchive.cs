using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class InternetCreditBatchArchive
    {
        public Guid CreditBatchArchiveID { get; set; }
        public int StoreID { get; set; }
        public DateTime BatchDate { get; set; }
        public byte[] ReportData { get; set; } = null!;
        public string MerchantID { get; set; } = null!;
        public byte[]? ReceiptData { get; set; }
    }
}
