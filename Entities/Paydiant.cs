using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Paydiant
    {
        public Guid PaydiantID { get; set; }
        public int StoreID { get; set; }
        public string StoreLocationID { get; set; } = null!;
        public string WebServiceURL { get; set; } = null!;
        public string MerchantID { get; set; } = null!;
        public string TerminalID { get; set; } = null!;
        public string GatewayURL { get; set; } = null!;
        public byte[] MerchantKey { get; set; } = null!;
        public int OfferMediaIndex { get; set; }
    }
}
