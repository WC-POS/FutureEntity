using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class CheckNumber
    {
        public Guid NextSaleID { get; set; }
        public int StoreID { get; set; }
        public int SaleNumber { get; set; }
        public int TicketNumber { get; set; }
        public DateTime? TicketNumberLastUpdate { get; set; }
    }
}
