using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CreditDeviceSaleStatus
    {
        public Guid CreditDeviceSaleStatusID { get; set; }
        public Guid SaleID { get; set; }
        public int Status { get; set; }
        public string? Info { get; set; }
        public int StoreID { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
