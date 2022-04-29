using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class OrderType
    {
        public Guid OrderTypeID { get; set; }
        public bool ApplyZoneCharge { get; set; }
        public int AuthSlipPrinter { get; set; }
        public string Description { get; set; } = null!;
        public bool DoNotOverrideCustomerZoneCharge { get; set; }
        public bool ExcludeCustomerInfoOnReceipt { get; set; }
        public int ForgiveTax { get; set; }
        public int Index { get; set; }
        public bool RequireDriver { get; set; }
        public int StoreID { get; set; }
        public int VDUColor { get; set; }
        public bool VDUNoBumpUntilSettled { get; set; }
        public int ZoneCharge { get; set; }
        public bool OverrideOrder { get; set; }
        public string OrderHeader { get; set; } = null!;
        public string OrderFooter { get; set; } = null!;
    }
}
