using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class RevenueCenter
    {
        public Guid RevenueCenterID { get; set; }
        public string Description { get; set; } = null!;
        public int Index { get; set; }
        public bool OverrideCCAMIP { get; set; }
        public bool OverridePMSRevenueCenter { get; set; }
        public int PMSRevenueCenter { get; set; }
        public int StoreID { get; set; }
        public byte[]? CCAMIP { get; set; }
        public byte[]? CreditModuleID { get; set; }
        public byte[]? CreditModuleKey { get; set; }
        public byte[]? MerchantID { get; set; }
        public byte[]? TerminalID { get; set; }
        public bool OverrideCreditSettings { get; set; }
    }
}
