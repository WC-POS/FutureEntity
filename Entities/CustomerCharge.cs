using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CustomerCharge
    {
        public Guid CustomerChargeID { get; set; }
        public int StoreID { get; set; }
        public int CustomerNumber { get; set; }
        public DateTime ChargeDate { get; set; }
        public short ChargeType { get; set; }
        public string? Description { get; set; }
        public byte TerminalNumber { get; set; }
        public short SupervisorID { get; set; }
        public int CheckNumber { get; set; }
        public int Amount { get; set; }
        public int SubTotal { get; set; }
        public int TaxTotal { get; set; }
        public int Gratuity { get; set; }
        public int TogoSurcharge { get; set; }
        public int AmoutRounded { get; set; }
        public Guid SaleID { get; set; }
        public Guid RegionID { get; set; }
    }
}
